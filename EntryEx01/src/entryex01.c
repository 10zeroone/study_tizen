#include "entryex01.h"

/*appdata_s 구조체가 정의되어
있습니다. 이것은 앱에서 사용하는 데이터를 저장하기 위한 구조체입니다.
기본적으로 Window, Conforment, Label이 선언되어 있습니다
*/
typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	//TODO 6: Entry에 입력된 내용 가져오기위해 Entry를 추가
	//Entry 위젯을 이벤트 함수에서 사용하기 위해서 전역변수 혹은 AppData로 선언
	Evas_Object *entry;
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

//TODO 1: Table 컨테이너에 위젯을 추가하는 함수
static void
my_table_pack(Evas_Object *table, Evas_Object *child, int x, int y, int w, int h)

{

evas_object_size_hint_align_set(child,  EVAS_HINT_FILL,  EVAS_HINT_FILL);
evas_object_size_hint_weight_set(child,    EVAS_HINT_EXPAND,   EVAS_HINT_EXPAND);
elm_table_pack(table, child, x, y, w, h);
evas_object_show(child);

}

//TODO 9: Button 콜백 함수
//Entry 위젯의 텍스트를 구해서 Label 위젯에 표시
//TODO 확인 - Entry위젯에 문자열 입력 후 Get Text버튼 클릭하여 이벤트 처리결과 확인하기
static void
btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s* ad = data;

	//elm_entry_entry_get() 은 Entry 위젯의 텍스트를 구하는 함수
	//elm_entry_entry_insert() 의 반대라고 생각하면 됩니다
	char* text = elm_entry_entry_get(ad->entry);
	//label위젯에 표시
	elm_object_text_set(ad->label, text);
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

	////TODO 2: 주석 처리
	/* Label */
	/* Create an actual view of the base gui.
	   Modify this part to change the view. */
//	ad->label = elm_label_add(ad->conform);
//	elm_object_text_set(ad->label, "<align=center>Hello Tizen</align>");
//	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	elm_object_content_set(ad->conform, ad->label);

	/*Table은 화면 비율 단위로 위젯을 배치할 수 있는 컨테이너 입니다.
	 * Entry의 배경으로 Bg를 사용하려면 같은 공간에 위치해야 하기 때문에 Table을 사용하는 것입니다.
	 * Box는 위젯 사이의 간격을 지정하기 위해서 사용하였습니다.*/
	//TODO 3: Box, Table  컨테이너와 Entry  위젯을  생성
	//TODO 확인 - Entry 위젯을 터치하면 키패드가 나타나서 새로운 텍스트를 입력할 수 있습니다.
	{
		Evas_Object *box = elm_box_add(ad->conform);
		evas_object_size_hint_weight_set(box,	EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

		elm_object_content_set(ad->conform,    box);
		evas_object_show(box);


		/* Table */
		//테이블 생성
		Evas_Object *table = elm_table_add(ad->conform);

		//
		elm_table_homogeneous_set(table,  EINA_TRUE);
		//elm_table_padding_set() 는 안쪽 여백을 지정하는 API
		elm_table_padding_set(table,	20	*	elm_config_scale_get(),	20	*
				elm_config_scale_get());

		evas_object_size_hint_weight_set(table,	EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

		evas_object_size_hint_align_set(table,   EVAS_HINT_FILL,   EVAS_HINT_FILL);
		elm_box_pack_end(box,  table);
		evas_object_show(table);


		{

			/* Label*/
			ad->label = elm_label_add(ad->conform);

			elm_object_text_set(ad->label,  "<align=center>Hello  EFL</align>");
			//시작 좌표(0, 0), 넓이와 높이(4, 1)
			my_table_pack(table, ad->label, 0, 0, 4, 1);



			//TODO 7: Button 위젯을 생성하고 Entry 위젯을 AppData 구조체에 저장
			/* Button-1 */
			Evas_Object  *btn  =  elm_button_add(ad->conform);
			elm_object_text_set(btn,  "Get  Text");
			evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, ad);
			my_table_pack(table, btn, 0, 1, 4, 1);



			/*Entry 위젯의 배경 컬러가 흰색이고, 화면 배경도 흰색이라서 Entry 위젯의 경계선이 확실하지 않습니다. Entry 위젯에 배경 컬러를 표시하는 방법은 2가지가 있습니다.
			 * 1번째는 Bg 위젯을 사용하는 것이고,
			 * 2번째는 EDJE를 사용하는 것입니다.*/
			//TODO 5: Bg로 배경 만들기
			//TODO 확인 - Bg 위젯을 Entry 보다 먼저 생성했고 영역좌표를 동일하게 지정하였습니다. 이렇게 하면 Bg가 Entry의 배경 처럼 보이게 됩니다
			/* Bg-1 */
			//Bg위젯 생성
			Evas_Object *bg = elm_bg_add(ad->conform);
			//컬러 지정
			elm_bg_color_set(bg, 170, 220, 255);
			//배경으로 넣기 위해 Entry 위젯과 동일한 영역좌표를 지정,
			//배경으로 쓸 Bg위젯을 먼저 만들고 entry위젯을 만들어야 배경으로 나오게 됩니다.
			my_table_pack(table, bg, 0, 2, 4, 1);


			/* Entry-1 */
			//elm_entry_add() 는 Entry 위젯을 생성하는 API
			Evas_Object  *entry  =  elm_entry_add(ad->conform);
			//elm_entry_single_line_set()  는 멀티라인 지정&해제 API입니다.	2번째 파라미터에 EINA_TRUE를 전달하면 한줄 입력 전용이 되고, EINA_FALSE를 전달하면 여러줄을 입력할 수 있습니
			elm_entry_single_line_set(entry, EINA_TRUE);
			//Entry 위젯에 캡션 텍스트를 추가하는 API입니다. 기존에 입력되어 있는 텍스트의 뒤에 새로운 텍스트가 추가
			elm_entry_entry_insert(entry,   "Entry-1");


			//TODO 8: 방근 생성한 entry위젯의 핸들 저장
			ad->entry = entry;



			//TODO 4: Guide 텍스트 표시
			//elm_object_part_text_set() 함수의 2번째 파라미터에 'elm.guide'를 전달하면 Entry 위젯에 Guide 텍스트를 지정할 수 있습니다. Guide 텍스트 내용을 3번째 파라미터에 전달하면 됩니다
			//TODO 확인 - 기존에 입력된 Entry위젯의 문자열을 모두 삭제하면 가이드 텍스트가 표시됩니다.
			elm_object_part_text_set(entry,  "elm.guide",  "Input  Text");
			//table컨테이너에 entry위젯 추가, 시작좌표(0, 2), 끝좌표(4, 1)
			my_table_pack(table, entry, 0, 2, 4, 1);
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
