#include "animatorex01.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	//TODO 1: 애니메이션을 적용할 사각형 객체 선언
	Evas_Object *rect1;
	Evas_Object *rect2;
} appdata_s;

//TODO 2: 변수 선언
//애니메이션을 계속할지 여부를 결정하는 Boolean 형식의 변수
Eina_Bool anim_continue = ECORE_CALLBACK_RENEW;
//애니메이션 스타일을 지정하는 옵션 타입
Ecore_Pos_Map pos_map = ECORE_POS_MAP_LINEAR;

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


//TODO 5: 프레임 이벤트 함수
//TODO 확인 - 파란색 사각형이 왼쪽에서 오른쪽으로 이동합니다. 어느 정도 이동하고 나면 다시 왼쪽 끝에서 이동을 계속합니다.
static Eina_Bool on_next_frame1(void *data)
{
	//사각형의 x좌표
	static int x = 0;

	if (x >= 350)
		x = 0;

	//evas_object_move() 는 객체의 위치를 변경하는 API입니다.
	//매 프레임 마다 x좌표를 2만큼 증가시킴니다. 그리고 x좌표가 350을 넘어서면 0에서 다시 시작합니다
	evas_object_move(data, x += 2, 50);

	//프레임 이벤트 함수에서 반환하는 값이 ECORE_CALLBACK_RENEW 이면 애니메이션을 계속하고,
	//ECORE_CALLBACK_CANCEL을 반환하면 애니메이션이 중지됩니다
	return anim_continue;
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

	//TODO 3: Conformant와 Label 생성 코드는 주석처리
	/* Conformant */
	/* Create and initialize elm_conformant.
	   elm_conformant is mandatory for base gui to have proper size
	   when indicator or virtual keypad is visible. */
	/*ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);*/

	/* Label */
	/* Create an actual view of the base gui.
	   Modify this part to change the view. */
	/*ad->label = elm_label_add(ad->conform);
	elm_object_text_set(ad->label, "<align=center>Hello Tizen</align>");
	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->label);*/


	//TODO 4: 1번째 사각형 객체와 Animator 객체를 생성
	/* Evas */
	//Rectangle  객체를 생성하기 위해서 Evas  객체를 생성합니다
	Evas *evas = evas_object_evas_get(ad->win);

	/* Rect-1 */
	ad->rect1  =  evas_object_rectangle_add(evas);
	evas_object_pass_events_set(ad->rect1, EINA_TRUE);
	evas_object_color_set(ad->rect1, 0,  0, 160, 160);
	//w, h(pixel)로 크기 지정
	evas_object_resize(ad->rect1, 50, 50);
	evas_object_show(ad->rect1);

	/* Animation-1 */
	//ecore_animator_add(Ecore_Task_Cb, void *)  는  Animator  객체를 	생성하는 API입니다.
	//1번째 파라미터는 프레임 이벤트 콜백 함수이고
	//2번째 파라미터는 사용자 데이터입니다. 주로 애니메이션을 적용할 객체 혹은 appdata를 전달합니다.
	Ecore_Animator *anim = ecore_animator_add(on_next_frame1, ad->rect1);

	//ecore_animator_frametime_set(double) 는 애니메이션 프레임 시간 간격을 지정하는 API입니다.
	//단위는 초단위 이며, 1/60을 지정하면 1초에 60번 프레임 이벤트가 발생합니다.
	ecore_animator_frametime_set(1. / 60);


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
