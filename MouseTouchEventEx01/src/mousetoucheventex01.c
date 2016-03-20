#include "mousetoucheventex01.h"

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

//TODO 2: 사용자가 Conformant를 Touch 했을 때 호출되는 콜백 함수 -
//on_mouse_down(), on_mouse_move(), on_mouse_up
//TODO 확인 - 마우스로 화면을 Touch하면 포인트 좌표가 Label 위젯에 표시됩니다
//TODO 확인 - 마우스를 드래그하면 이전 Touch 포인트 좌표와 현재 Touch 포인트 좌표가 Label 위젯에 표시됩니다
//TODO 확인 - 마우스 Touch를 해제하면 마지막 포인트 좌표가 Label 위젯에 표시됩니다
//on_mouse_down() 는 Conformant를 Touch 다운했을 때의 콜백 함수입니다.
//1번째 파라미터에는 사용자 데이터가 전달되고,
//2번째 파라미터에는 이벤트가 발생한 객체가 전달됩니다.
//3번째 파라미터에는 Touch 이벤트 정보가 저장된 Evas_Event_Mouse_Down 객체가 전달됩니다.
static void
on_mouse_down(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;

	//Evas_Event_Mouse_Down 객체의 속성 중에서 canvas에는 Touch 포인트 좌표가 저장되어 있습니다
	Evas_Event_Mouse_Down *ev = event_info;
	char buf[100];

	sprintf(buf, "Win Mouse down:%d,%d", ev->canvas.x, ev->canvas.y);
	elm_object_text_set(ad->label, buf);
}

//on_mouse_move() 는 Conformant를 Touch 이동했을 때의 콜백 함수입니다.
//1번째 파라미터에는 사용자 데이터가 전달되고,
//2번째 파라미터에는 이벤트가 발생한 객체가 전달됩니다.
//3번째 파라미터에는 Touch 이벤트 정보가 저장된 Evas_Event_Mouse_Move 객체가 전달됩니다.
static void
on_mouse_move(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;

	Evas_Event_Mouse_Move *ev = event_info;
	char buf[100];

	//Evas_Event_Mouse_Move 객체의 속성 중에서 prev.canvas에는 이전 Touch 포인트 좌표가 저장되어 있습니다.
	//cur.canvas에는 현재 Touch 포인트 좌표가 저장되어 있습니다.
	sprintf(buf, "Win Mouse move:%d,%d/%d,%d",
			ev->prev.canvas.x,  ev->prev.canvas.y,  ev->cur.canvas.x,  ev->cur.canvas.y);
	elm_object_text_set(ad->label, buf);
}

//on_mouse_up()  은 Conformant를  Touch  해제했을  때의  콜백  함수입니다.
//1번째  파라미터에는  사용자  데이터가  전달되고,
//2번째  파라미터에는 이벤트가  발생한  객체가  전달됩니다.
//3번째  파라미터에는  Touch  이벤트 정보가 저장된 Evas_Event_Mouse_Up  객체가 전달됩니다
static void
on_mouse_up(void *data, Evas *e, Evas_Object *obj, void *event_info)
{

	appdata_s *ad = data;
	Evas_Event_Mouse_Up *ev = event_info;
	char buf[100];

	//Evas_Event_Mouse_Up  객체의 속성 중에서 canvas에는 Touch  포인트 좌표가  저장되어  있습니다.
	sprintf(buf, "Win Mouse up:%d,%d", ev->canvas.x, ev->canvas.y);
	elm_object_text_set(ad->label, buf);
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

	/* Label */
	/* Create an actual view of the base gui.
	   Modify this part to change the view. */
	ad->label = elm_label_add(ad->conform);
	elm_object_text_set(ad->label, "<align=center>Hello Tizen</align>");
	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->label);


	//TODO 1: 컨테이너 Touch 이벤트 구하기
	/* Mouse Touch event callback */
	//evas_object_event_callback_add() 은 evas 객체에 콜백 함수를 지정하는 API입니다. evas 객체는 화면에 보여지는 모든 객체를 의미합니다. 따라서 기본 객체(Line, Rect, Polygon, Text, Image)와 스마트 객체(컨테이너, 위젯)를 모두 포함합니다.
	//1번째 파라미터에는 이벤트가 발생하는 객체를 지정합니다. 여기서는 Conformant를 지정하였습니다.
	//2번째 파라미터에는 이벤트의 종류를 지정합니다
	//3번째 파라미터는 콜백 함수명을 지정하고,
	//4번째는 사용자 데이터입니다.
	//EVAS_CALLBACK_MOUSE_DOWN 는 Touch 다운 이벤트를 의미
	evas_object_event_callback_add(  ad->conform,  EVAS_CALLBACK_MOUSE_DOWN, on_mouse_down , ad);
	//EVAS_CALLBACK_MOUSE_MOVE 는 Touch 이동 이벤트를 의미
	evas_object_event_callback_add(  ad->conform,  EVAS_CALLBACK_MOUSE_MOVE, on_mouse_move , ad);
	//EVAS_CALLBACK_MOUSE_UP 는 Touch 해제 이벤트를 의미
	evas_object_event_callback_add(	ad->conform, EVAS_CALLBACK_MOUSE_UP, on_mouse_up , ad);


	//TODO 3: 멀티 Touch 이벤트 구하기
	/* Multi Touch event callback */
	evas_object_event_callback_add(ad->conform,	EVAS_CALLBACK_MULTI_DOWN, multi_down_cb, ad);
	evas_object_event_callback_add(ad->conform,	EVAS_CALLBACK_MULTI_MOVE, multi_move_cb, ad);


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
