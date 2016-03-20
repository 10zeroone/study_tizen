#include "calculator.h" //개발자가 만든 것
//STEP 1: 화면 UI 구성
//TODO 01: 수학함수 라이브러리 헤더파일
#include <math.h> //SDK에서 제공해주는 것

//TODO 02: define 문에는 Button을 구분하기 위한 ID를 정의
#define ID_BACK		101
#define ID_CLEAR	102
#define ID_DOT		103
#define ID_EQUAL	104
#define ID_PLUS		111
#define ID_MINUS	112
#define ID_MULTIPLY	113
#define ID_DIVIDE	114
#define ID_X2		121
#define ID_X3		122
#define ID_SQRT		123
#define ID_RECIPE	124


typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	//TODO 03: appdata 구조체에  변수 추가
	Evas_Object *entry; //계산 결과값을 표시
	float  value; //임시 계산 결과값을 저장
	int calc_mode; //연산의 종류(+, - , *, /)를 저장

} appdata_s;


//STEP 2: 숫자 Button 기능 구현
//0~9까지의 숫자 Button을 클릭하면 Label 위젯에 해당 숫자가 추가되는 기능을 구현해 보겠습니다

//TODO 07: appdata를 전역변수로 선언
appdata_s* m_ad = 0;


static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

//TODO 09: get_entry_value() 는 entry 캡션 텍스트를 float 형식으로 변경해서 반환하는 함수입니다
static float
get_entry_value()
{
	char* text = elm_object_text_get(m_ad->entry);
	float value = atof(text);
	return value;
}

//TODO 10: append_number_label() 는 char 변수를 받아서 entry 캡션 텍스트 끝에 추가하는 함수입니다
static void append_number_label(char str_new) {
	char buf[100];

	char* text = elm_object_text_get(m_ad->entry);
	float value = get_entry_value();

	if( value == 0.f ) // 0인 경우 새로들어온 문자 추가
		sprintf(buf, "%c", str_new);
	else //0이 아니면 기존의 문자열에 추가하여 문자열 작성
		sprintf(buf, "%s%c", text, str_new);

	elm_object_text_set(m_ad->entry, buf);
}


//STEP : 사칙연산
//TODO 13: set_label_value() 는 실수값을 받아서 문자열로 변환한 다음 Label 위젯에 입력하는 함수
static void
set_entry_value(float value)
{

	char buf[100];
	sprintf(buf, "%f", value);
	elm_object_text_set(m_ad->entry, buf);

}

//TODO 14: btn_equal_clicked() 는 연칙연산 종류에 따라서 2개의 숫자를 계산하는 함수
static void btn_equal_clicked()
{

	float value2 = get_entry_value();

	switch( m_ad->calc_mode )
	{
	case  ID_PLUS  :
		m_ad->value += value2;
		break;
	case ID_MINUS :
		m_ad->value -= value2;
		break;
	case ID_MULTIPLY :
		m_ad->value *= value2;
		break;
	case ID_DIVIDE :
		m_ad->value /= value2;
		break;
	}

	set_entry_value(m_ad->value);
}


//TODO 04: Button 생성 함수 추가
//많은 숫자의 Button 위젯을 생성하게 되므로 소스코드를 줄이기 위해서 새로운 함수 2개를 추가
//btn_clicked_cb() 는 Button 콜백 함수입니다. 여러개의 Button이 동일한 콜백 함수를 호출하게 됩니다.
static void
btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	//TODO 11: 사용자가 숫자 Button을 클릭하면 append_number_label 함수를 호출해주기
	//TODO 확인 - 숫자 Button을 클릭하면 Label 위젯에 해당 숫자가 추가되는 것 확인하기
	char* text = NULL;
	int length = 0;
	float value = 0.f;
	int id = (int)data;

	//사용자 데이터가 0~9 사이인 경우에는 숫자 Button 으로 간주하고 Label 위젯의 캡션 텍스트에 새로운 문자를 추가합니다
	if( id >= 0 && id <= 9 )
	{
		//id 정수값을 char로 변경하기 위해서 '0' + id
		append_number_label('0' + id); //'1' = '0' + 1

		return;
	}


	//STEP 3: Dot, Clear, Back Button 기능 구현
	//TODO 12: Dot, Clear, Back Button 버튼 기능 구현
	//TODO 확인 - 숫자 '.' Button을 누르면 Label 텍스트 	오른쪽 끝에 '.' 기호가 추가됩니다.
	//Back Button을 누르면 오른쪽 한 문자가 삭제됩니다. Clear Button을 누르면 텍스트 전체가 0으로 변경됩니다.
	switch( id )
	{
	case ID_DOT : //사용자가 '.' Button을 클릭했다면 Label 텍스트 끝에 '.' 기호를 추가합니다
		append_number_label('.');
		break;
	case ID_CLEAR : //사용자가 Clear Button을 클릭했다면 Label 텍스트를 '0' 으로 변경합니다.
		elm_object_text_set(m_ad->entry, "0");
		break;
	case ID_BACK : //사용자가 Back Button을 클릭했다면 Label 텍스트 끝 문자를 삭제합니다.
		text = elm_object_text_get(m_ad->entry);
		length = strlen(text);

		if( length > 0 ){
			//eina_stringshare_add_length(char*, unsigned int) 는 길이를 지정해서 문자열 앞부분을 추출해 주는 API
			text = eina_stringshare_add_length(text, length - 1);
		}
		if( strlen(text) < 1 )
			text = "0";
		elm_object_text_set(m_ad->entry,text);
		break;

	//TODO 15: 사칙연산 버튼 클릭 확인 코드
	//TODO 확인 - 예제를 다시 실행하고 '11'을 입력했다가 '+' Button을 누르면 Entry 위젯에 '0'이 표시됩니다.
	//그런 다음 '35'를 입력했다가 '=' Button을 누르면 Entry 위젯에 연산 	결과가 표시됩니다.
	//뺄셈, 곱셈, 나눗셈도 테스트 해보기 바랍니다.
	case ID_PLUS :
	case ID_MINUS :
	case ID_MULTIPLY :
	case ID_DIVIDE :
		//사용자가 사칙연산 Button을 누르면 Entry 텍스트를 숫자로 변경해서 전역변수에 저장합니다.
		//Entry 텍스트는 '0' 으로 변경하고 사칙연산 종류를 전역변수에 저장해 둡니다.
		m_ad->value = get_entry_value();
		elm_object_text_set(m_ad->entry, "0");
		m_ad->calc_mode = id;
		break;
	case ID_EQUAL : //사용자가 '=' Button을 클릭하면 btn_equal_clicked() 함수를 호출합니다
		btn_equal_clicked();
		break;
	//STEP : 제곱, 제곱근 구하기
	//TODO 16: 제곱, 제곱근 버튼 클릭 확인
	case ID_X2 :
		//Entry위젯의 값 가져오기
		value = get_entry_value();
		//pow(double, double) 은 제곱값을 구하는 수학함수입니다.
		//2번째 파라미터에 2를 전달하면 제곱값을 반환하고, 3을 전달하면 3제곱값을 반환합니다.
		value = pow( value, 2 ); //제곱
		set_entry_value(value);
		break;
	case ID_X3 :
		value = get_entry_value();
		value = pow( value, 3 ); //세제곱
		set_entry_value(value);
		break;
	case ID_SQRT : //제곱근
		value = get_entry_value();
		//sqrt(double) 는 제곱근을 반구하는 수학함수
		value = sqrt( value );
		set_entry_value(value);
		break;
	case ID_RECIPE : //역수를 구할 때는 1을 숫자로 나눠주면 됩니다
		value = get_entry_value();
		value = 1.f / value;
		set_entry_value(value);
		break;
	}
}

//create_button() 은 Button 관련 정보를 받아서 Button 위젯을 생성하는 함수입니다
//int x, int y, int w, int h : 위치와 크기
//void *data: 사용자 데이터
static void
create_button(Evas_Object *parent, const char* text, int x, int y, int w, int h, void *data)
{
	//버튼 생성
	Evas_Object *btn = elm_button_add(parent);
	//캡션 텍스트 설정
	elm_object_text_set(btn, text);

	//테이블 컨테이너의 셀의 크기만큼 설정됩니다.
	evas_object_size_hint_weight_set(btn,   EVAS_HINT_EXPAND,   EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn,  EVAS_HINT_FILL,  EVAS_HINT_FILL);
	//버튼의 x, y, w, h 지정
	elm_table_pack(parent, btn, x, y, w, h);
	//버튼 콜백 함수 지정
	evas_object_smart_callback_add(btn,  "clicked",  btn_clicked_cb,  data);
	//화면에 보여주기
	evas_object_show(btn);
}



static void
create_base_gui(appdata_s *ad)
{
	//TODO 08: appdata 변수를 초기화
	m_ad = ad;


	/* Window */
	/* Create and initialize elm_win.
	   elm_win is mandatory to manipulate window. */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	   elm_conformant is mandatory for base gui to have proper size
	   when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	//TODO 05: Label 주석처리
	/* Label */
	/* Create an actual view of the base gui.
	   Modify this part to change the view. */
	/*ad->label = elm_label_add(ad->conform);
	elm_object_text_set(ad->label, "<align=center>Hello Tizen</align>");
	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->label);*/

	//TODO 06: Box와 Table 그리고 22개의 Button을 생성하기
	//TODO 확인 - 화면 위쪽에 Entry 위젯이 있고 그 아래에 22개의 Button 위젯이 생성되었습니다.
	//위젯들을 비율 단위로 화면에 배치하기 위해서 Table을 생성하였고, 위젯 사이에 간격을 지정하기 위해서 Box를 생성하였습니다.
	{
		Evas_Object *box = elm_box_add(ad->win);
		evas_object_size_hint_weight_set(box,	EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

		elm_win_resize_object_add(ad->win,   box);

		evas_object_show(box);


		/* Table */
		Evas_Object *table = elm_table_add(ad->win);

		/* Make table homogenous - every cell will be the same size */
		elm_table_homogeneous_set(table,  EINA_TRUE);
		/* Set padding of 10 pixels multiplied by scale factor of UI */
		elm_table_padding_set(table,	10	*	elm_config_scale_get(),	10	*  elm_config_scale_get());

		/* Let the table child allocation area expand within in the box */
		evas_object_size_hint_weight_set(table,	EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

		/* Set table to fiill width but align to bottom of box */
		evas_object_size_hint_align_set(table, EVAS_HINT_FILL, 1.0); elm_object_content_set(ad->conform,    table); evas_object_show(table);


		{ /* child object - indent to how relationship */

			/* Entry */
			//계산 결과값을 표시하기 위해서 Entry 위젯을 생성하였습니다
			ad->entry = elm_entry_add(ad->win); elm_object_text_set(ad->entry, "0");
			evas_object_size_hint_weight_set(ad->entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_align_set(ad->entry,	EVAS_HINT_FILL, EVAS_HINT_FILL);
			elm_table_pack(table, ad->entry, 0, 0, 4, 1);
			evas_object_show(ad->entry);

			/* Button */
			//총 22개의 Button 위젯을 생성하는 코드입니다. 숫자 Button 인 경우에는 콜백 함수에 해당 숫자값을 사용자 데이터로 전달합니다
			//그외 Button 인 경우에는 define 문에서 정의한 ID 값을 사용자 데이터로 전달합니다.
			create_button(table, "Back", 0, 1, 2, 1, ID_BACK);
			create_button(table, "Clear", 2, 1, 2, 1, ID_CLEAR);

			create_button(table, "7", 0, 2, 1, 1, 7);
			create_button(table, "8", 1, 2, 1, 1, 8);
			create_button(table, "9", 2, 2, 1, 1, 9);
			create_button(table, "/", 3, 2, 1, 1, ID_DIVIDE);

			create_button(table, "4", 0, 3, 1, 1, 4);
			create_button(table, "5", 1, 3, 1, 1, 5);
			create_button(table, "6", 2, 3, 1, 1, 6);
			create_button(table, "*", 3, 3, 1, 1, ID_MULTIPLY);

			create_button(table, "1", 0, 4, 1, 1, 1);
			create_button(table, "2", 1, 4, 1, 1, 2);
			create_button(table, "3", 2, 4, 1, 1, 3);
			create_button(table, "-", 3, 4, 1, 1, ID_MINUS);

			create_button(table, "0", 0, 5, 1, 1, 0);
			create_button(table, ".", 1, 5, 1, 1, ID_DOT);
			create_button(table, "=", 2, 5, 1, 1, ID_EQUAL);
			create_button(table, "+", 3, 5, 1, 1, ID_PLUS);

			create_button(table, "x^2", 0, 6, 1, 1, ID_X2);
			create_button(table, "x^3", 1, 6, 1, 1, ID_X3);
			create_button(table, "sqrt", 2, 6, 1, 1, ID_SQRT);
			create_button(table, "1/x", 3, 6, 1, 1, ID_RECIPE);
		}
	}


	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
