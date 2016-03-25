#include "timerex01.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;

	//TODO 1: appdata 구조체에 새로운 변수 선언
	//Ecore_Timer 는 타이머 구조체
	Ecore_Timer  *timer1;
	//타이머 이벤트 발생 회수를 저장하는 변수
	int  timer_count;
} appdata_s;

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


//TODO 2: Box에 위젯을 추가하는 함수
static void
my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight, double v_weight, double h_align, double v_align)
{

	evas_object_size_hint_weight_set(child,  h_weight,  v_weight);
	evas_object_size_hint_align_set(child, h_align, v_align);
	evas_object_show(child);

	elm_box_pack_end(box,  child);
}

//TODO 3: Button 위젯을 생성해서 반환하는 함수
//Evas_Smart_Cb cb : 스마트 콜백함수의 이름
static Evas_Object *
my_button_add(Evas_Object *parent, const char *text, Evas_Smart_Cb cb, void *cb_data)
{
	Evas_Object *btn;

	btn = elm_button_add(parent); elm_object_text_set(btn, text);
	//버튼 클릭 이벤트 함수 지정
	evas_object_smart_callback_add(btn,  "clicked",  cb,  cb_data);

	return btn;
}


//TODO 7: 타이머 이벤트 콜백 함수
//TODO 확인 - Start 버튼을 누르면 1초에 한번씩 Label 위젯에 숫자가 증가합니다
//타이머 회수를 증가하고, 현재 카운트를 화면에 표시하는 코드
static Eina_Bool
timer1_cb(void *data EINA_UNUSED)
{
	appdata_s *ad = data;
	ad->timer_count ++; //타이머 회수를 증가
	char buf[100];
	sprintf(buf, "Count - %d", ad->timer_count);
	//현재 카운트를 화면에 표시
	elm_object_text_set(ad->label, buf);

	return ECORE_CALLBACK_RENEW;
}


//TODO 6: 콜백 함수 생성
static void
btn_start_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	ad->timer_count = 0;
	//ecore_timer_add(double, Ecore_Task_Cb, void*) 는 새로운 타이머를 생성해서 반환하는 API입니다.
	//1번째 파라미터는 시간 간격입니다. 단위는 Second 입니다. 만약 1.5초 마다 이벤트가 발생하려면 1.5를 전달하면 됩니다,
	//2번째 파라미터는 타이머 이벤트 콜백 함수명,
	//3번째는 사용자 데이터 입니다
	ad->timer1 = ecore_timer_add(1.0, timer1_cb, ad);
	elm_object_text_set(ad->label, "Timer started");
}

static void
btn_stop_cb(void *data, Evas_Object *obj, void *event_info)
{ //TODO 8: 타이머 중지
  //TODO 확인 - Start 버튼을 눌렀다가 잠시 후에 Stop 버튼을 누르면 타이머 이벤트가 중지됩니다.

	//사용자 데이터를 appdata타입으로 변환
	appdata_s *ad = data;
	//ecore_timer_freeze(Ecore_Timer*) 는 타이머 이벤트를 일시정지하는 API입니다.
	//다시 재시작하려면 ecore_timer_thaw() 함수를 사용하면 됩니다.
	ecore_timer_freeze(ad->timer1);
	//ecore_timer_del(Ecore_Timer*) 는 타이머 객체를 삭제하는 API
	ecore_timer_del(ad->timer1);
	elm_object_text_set(ad->label, "Timer stopped");
}


static void
create_base_gui(appdata_s *ad)
{
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

	//TODO 4: Label 부분 주석 처리
	/* Label */
	/* Create an actual view of the base gui.
	   Modify this part to change the view. */
/*	ad->label = elm_label_add(ad->conform);
	elm_object_text_set(ad->label, "<align=center>Hello Tizen</align>");
	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->label);*/

	//TODO 5: Box와 	2개의 Button을 생성
	{
		Evas_Object *btn, *box;

		/* Container: standard box */
		box = elm_box_add(ad->win);
		//Box컨테이너의 내부 위젯이 위치하는 방향을 지정, EINA_TRUE:HORIZONTLA/EINA_FALSE: VERTICAL로 지정됨
		elm_box_horizontal_set(box, EINA_FALSE);
		evas_object_size_hint_weight_set(box,	EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(box,   EVAS_HINT_FILL,   EVAS_HINT_FILL);
		elm_object_content_set(ad->conform,    box);
		evas_object_show(box);

		{
			/* Label */
			ad->label = elm_label_add(box);
			//캡션 텍스트 지정
			elm_object_text_set(ad->label, "No timer");
			my_box_pack(box, ad->label, EVAS_HINT_EXPAND, 0.0, 0.5, 0.0);


			/* Button-1 */
			//1번째 Button은 타이머를 시작하는 기능을 담당합니다
			btn = my_button_add(box, "Start", btn_start_cb, ad);
			//Button을 Box컨터네이너에 추가
			my_box_pack(box, btn, EVAS_HINT_EXPAND,	0, EVAS_HINT_FILL, EVAS_HINT_FILL);


			/* Button-2 */
			btn = my_button_add(box, "Stop", btn_stop_cb, ad);

			my_box_pack(box, btn, EVAS_HINT_EXPAND,	EVAS_HINT_EXPAND, EVAS_HINT_FILL, 0.0);
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
