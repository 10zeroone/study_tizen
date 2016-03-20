#include "drawrectex01.h"

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

	//TODO 1: 주석처리
	/* Label */
	/* Create an actual view of the base gui.
	   Modify this part to change the view. */
//	ad->label = elm_label_add(ad->conform);
//	elm_object_text_set(ad->label, "<align=center>Hello Tizen</align>");
//	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	elm_object_content_set(ad->conform, ad->label);


	//TODO 2: 캔버스 생성 & 사각형 그리기
	//TODO 확인 - 분홍색 사각형이 화면에 표시되었습니다. 빨간색을 지정했지만 반투명이 적용되어서 분홍색 처럼 보이게 됩니다.
	{ /* child object - indent to how relationship */
		/* A grid to stretch content within grid size */
		//elm_grid_add() 는 Grid 컨테이너를 생성하는 API 입니다. Grid는 오브젝트를 비율 단위로 화면에 배치할수 있는 컨테이너 입니다. Table은 셀 단위로 영역을 구분하고, Grid는 기본적으로 Max 값이 100으로 지정되어 있다는 것이 다릅니다
		Evas_Object *grid = elm_grid_add(ad->win);
		evas_object_size_hint_weight_set(grid,	EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_object_content_set(ad->conform,    grid);
		evas_object_show(grid);

		{

			/* Canvas */
			//evas_object_evas_get(Evas_Object *)  는 Evas 객체를 생성하는 API
			Evas* canvas = evas_object_evas_get(ad->win);

			/* Rect-1 */
			//evas_object_rectangle_add(Evas *) 는 캔버스에 Rectangle 객체를 생성하는 API
			Evas_Object *rect = evas_object_rectangle_add(canvas);

			//evas_object_color_set(Evas_Object *, int, int, int, int)  는 도형에 컬러를 지정하는 API입니다.  파라미터는 순서대로 Red, Green, Blue, 반투명도입니다. 255, 0, 0, 192로 지정하면  반투명이 적용된 빨간색 컬러가  만들어  집니다
			evas_object_color_set(rect, 255, 0, 0, 192);
			evas_object_show(rect);

			//elm_grid_pack() 은 Grid 컨테이너에 오브젝트를 배치하는 API 입니다.
			//1번째 파라미터는 Grid, 2번째는 오브젝트, 3번째는 수평 위치, 4번째는 수직 위치, 5번째는 수평 넓이, 6번째는 수직 넓이 입니다. 3번째 파라미터에 4를 전달하면 수평 방향으로 4% 위치를 의미합니다.
			elm_grid_pack(grid, rect, 4, 5, 52, 31);



			//TODO 3: 반투명 사각형 중첩
			//TODO 확인 - 2개의 사각형을 추가해서 영역이 겹칠때 컬러가 어떻게 달라지는지 확인
			//3개의 사각형이 화면에 표시 되었습니다. 중첩된 부분은 중간 컬러로 바뀜
			/* Rect-2 */
			//2번째 사각형의 컬러는 반투명이 적용된 Green으로 지정
			rect = evas_object_rectangle_add(canvas);
			evas_object_color_set(rect, 0, 255, 0, 192);
			evas_object_show(rect);
			elm_grid_pack(grid, rect, 44, 5, 52, 31);

			/* Rect-3 */
			//3번째 사각형의 컬러는 반투명이 적용된 Blue로 지정
			rect = evas_object_rectangle_add(canvas);
			evas_object_color_set(rect, 0, 0, 255, 192);
			evas_object_show(rect);
			elm_grid_pack(grid, rect, 24, 29, 52, 31);



			//elm_grid_size_set(obj, w, h)  은 Grid  사이즈 수치를 지정하는 API  입니다.
			//기본 값은 수평으로 100,  수직으로 100  입니다.

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
