#include "listex01.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
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

//TODO 1: Box에 위젯을 추가하는 함수
static void
my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight, double v_weight, double h_align, double v_align)
{

	evas_object_size_hint_weight_set(child,  h_weight,  v_weight);
	evas_object_size_hint_align_set(child, h_align, v_align);
	evas_object_show(child);

	elm_box_pack_end(box,  child);
}


//TODO 5: List 위젯 항목을 선택했을 때 호출되는 콜백 함수
//TODO 확인 - 이번에는 선택표시가 나타났다가 사라집니다.
static void
list_selected_cb(void *data, Evas_Object *obj, void *event_info)
{
	Elm_Object_Item *it = event_info;
	//elm_list_item_selected_set()  는 List  위젯 항목 선택 표시를 지정/해제 하는 API입니다.
	//1번째 파라미터는 항목의 객체를 전달하면 되는데,  콜백 함수  3번째  파라미터에  넘어오는  event_info를  전달하면  됩니다.
	//2번째 파라미터에 EINA_TRUE를 전달하면 선택 표시가 나타나고, EINA_FALSE를 전달하면  선택  표시가  사라집니다.
	elm_list_item_selected_set(it,    EINA_FALSE);
}

//TODO 7: 항목 선택 이벤트 콜백 함수
//사용자가 List 위젯의 항목을 선택하면 위 함수가 호출됩니다.
//1번째 파라미터에는 항목 인덱스 번호가 전달됩니다.
//2번째 파라미터에는 List 위젯의 객체가 전달되고,
//3번째 파라미터에는 선택된 항목의 객체가 전달됩니다.
//TODO 확인 - 인덱스 번호와 항목 텍스트를 문자열 변수에 저장해서 로그창에 표시
static void
list_item_clicked(void *data, Evas_Object *obj, void *event_info)
{
	int index = (int)data;
	Elm_Object_Item *it = event_info;
	//elm_object_item_text_get() 는 항목의 텍스트를 반환하는 API
	const char *item_text = elm_object_item_text_get(it);

	char  buf[PATH_MAX];

	sprintf(buf, "%d - %s", index, item_text);
	dlog_print(DLOG_INFO, "tag", "%s", buf);
//	dlog_print(DLOG_INFO, "tag", "%s", buf, index, item_text);
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

	//TODO 2: 주석처리
	/* Label */
	/* Create an actual view of the base gui.
	   Modify this part to change the view. */
//	ad->label = elm_label_add(ad->conform);
//	elm_object_text_set(ad->label, "<align=center>Hello Tizen</align>");
//	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	elm_object_content_set(ad->conform, ad->label);

	//TODO 3: Box 컨테이너와 List 위젯을 생성하겠습니다. 그런 다음 10개의 텍스트 항목을 추가
	//TODO 확인 - 리스트 표시되는 것 확인
	{
		/* child object - indent to how relationship */

		/* A box to put things in verticallly - default mode for box */ Evas_Object *box = elm_box_add(ad->win);
		evas_object_size_hint_weight_set(box,	EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

		elm_object_content_set(ad->conform,    box);
		evas_object_show(box);

		{
			/* Label*/

			ad->label = elm_label_add(ad->conform);

			elm_object_text_set(ad->label,  "<align=center>Hello  EFL</align>");

			//이코드는 my_box_pack()함수에서 하므로 없어도 되는 코드
			//evas_object_size_hint_weight_set(ad->label,	EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

			my_box_pack(box, ad->label, 1.0, 0.0, -1.0, 0.5);


			/* List */
			//10개의 텍스트 항목을 추가
			const  char  *items[]  =  {  "Seoul",  "Tokyo",  "Newyork",  "Londeon", "Baijing", "Kongga", "Moscuba", "Singgapol", "Pusan", "Hongkong" };
			//elm_list_add() 는 새로운 List 위젯을 추가하는 API
			Evas_Object *list = elm_list_add(ad->conform);


			for(int i=0; i < 10; i++){
				//elm_list_item_append() 는 List 위젯에 항목을 추가하는 API입니다.
				//1번째 파라미터는 List 위젯의 객체이고,
				//2번째는 텍스트 문자열입니다.
				//3번째는 	왼쪽 아이콘,
				//4번째 파라미터는 오른쪽 아이콘입니다.
				//5번째는 항목 선택 이벤트 함수를 콜백 스타일로 지정합니다. 6번째는 사용자 데이터를 전달합니다.
				//일반적으로 appdata를 전달하지만 몇 번째 항목인지를 알기 위해서 인덱스 번호를 전달하였습니다
//				elm_list_item_append(list, items[i], NULL, NULL, NULL, (void*)i);

				//TODO 6: 동일 메소드는 주석 처리
				//사용자가 List 위젯 항목을 선택하면 해당 항목의 인덱스 번호와 텍스트를 구해서 Label 위젯에 표시하는 기능을 구현하기 위해
				//항목 선택 이벤트 콜백 함수를 list_item_clicked로 지정
				elm_list_item_append(list, items[i], NULL, NULL, list_item_clicked, (void*)i);

				//elm_list_go() 는 화면을 갱신해서 변경된 항목을 화면에 표시하는 API입니다.
				//새로운 항목을 추가하거나 항목 삭제 혹은 수정했을 경우 이 함수를 호출해 주어야 화면에 결과가 보여지는 것입니
				elm_list_go(list);



				//TODO 4: 선택 표시 자동 해제
				//항목을 선택했을 때 선택 표시가 사라지지 않고 남아있습니다. 이 기능이 필요한 경우도 있지만 그렇지 않은 경우도 있습니다
				evas_object_smart_callback_add(list, "selected", list_selected_cb, NULL);
			}
			my_box_pack(box, list, 1.0, 1.0, -1.0, -1.0);

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
