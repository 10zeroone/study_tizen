S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDU0BOL4
Build-Date: 2015.12.24 17:18:01

Crash Information
Process Name: calculator
PID: 9900
Date: 2016-03-20 17:06:25+0900
Executable File Path: /opt/usr/apps/org.example.calculator/bin/calculator
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9900, uid 5000)

Register Information
r0   = 0xfffffff8, r1   = 0x00000000
r2   = 0x2fd5fa00, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb77eaf18
r6   = 0xb77e6688, r7   = 0xbeffd1f0
r8   = 0x800148a5, r9   = 0xb5f01708
r10  = 0xb77d8aa0, fp   = 0xb5fda640
ip   = 0xffffffff, sp   = 0xbeffd1b8
lr   = 0xb2815a3d, pc   = 0xb67130e4
cpsr = 0x600b0030

Memory Information
MemTotal:   987012 KB
MemFree:     84148 KB
Buffers:     51804 KB
Cached:     334920 KB
VmPeak:     125468 KB
VmSize:     125464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22664 KB
VmRSS:       22664 KB
VmData:      41488 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35696 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9900 TID = 9900
9900 9901 9959 9960 9972 

Maps Information
afa81000 b0280000 rw-p [stack:9972]
b133a000 b1b39000 rw-p [stack:9960]
b1b7c000 b1b8d000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b9d000 b1ba2000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1bb2000 b1bba000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bcb000 b1bcc000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bdc000 b1bf0000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c04000 b1c05000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c15000 b1c18000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c29000 b1c2a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c3a000 b1c3c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c4c000 b1c4e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c5e000 b1c6e000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c7e000 b1c8a000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c9c000 b249b000 rw-p [stack:9959]
b27cc000 b27d3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27e4000 b27ec000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27fe000 b2804000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2814000 b2816000 r-xp /opt/usr/apps/org.example.calculator/bin/calculator
b2966000 b2a49000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a80000 b2aa8000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aba000 b32b9000 rw-p [stack:9901]
b32b9000 b32bb000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32cb000 b32d5000 r-xp /lib/libnss_files-2.20-2014.11.so
b32e6000 b32ef000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3300000 b3311000 r-xp /lib/libnsl-2.20-2014.11.so
b3324000 b332a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b333b000 b333c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3364000 b336b000 r-xp /usr/lib/libminizip.so.1.0.0
b337b000 b3380000 r-xp /usr/lib/libstorage.so.0.1
b3390000 b33ef000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3405000 b3419000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3429000 b346d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b347d000 b3485000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3495000 b34c5000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34d8000 b3591000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35a5000 b35f8000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3609000 b3624000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3634000 b36f5000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3708000 b3718000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3728000 b3735000 r-xp /usr/lib/libmdm-common.so.1.0.97
b3746000 b374d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b375d000 b379e000 r-xp /usr/lib/libmdm.so.1.2.12
b37ae000 b37b6000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37c5000 b37d5000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37f6000 b3856000 r-xp /usr/lib/libasound.so.2.0.0
b3868000 b386b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b387b000 b387e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b388e000 b3893000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38a3000 b38a4000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38b4000 b38be000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38d2000 b38d9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e9000 b38ef000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38ff000 b3904000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3914000 b392e000 r-xp /usr/lib/libmmfsound.so.0.1.0
b393f000 b3946000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3956000 b3959000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b396a000 b3998000 r-xp /usr/lib/libidn.so.11.5.44
b39a8000 b39be000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39cf000 b39d9000 r-xp /usr/lib/libcares.so.2.1.0
b39e9000 b39f3000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b3a03000 b3a05000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a15000 b3a16000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a26000 b3a2a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a3b000 b3a63000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a74000 b3a9d000 r-xp /usr/lib/libturbojpeg.so
b3abd000 b3ac3000 r-xp /usr/lib/libgif.so.4.1.6
b3ad3000 b3b19000 r-xp /usr/lib/libcurl.so.4.3.0
b3b2a000 b3b4b000 r-xp /usr/lib/libexif.so.12.3.3
b3b66000 b3b7b000 r-xp /usr/lib/libtts.so
b3b8c000 b3b94000 r-xp /usr/lib/libfeedback.so.0.1.4
b3ba4000 b3c6a000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c8a000 b3d82000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3da1000 b3e6f000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e86000 b3e88000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e98000 b3e9e000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eae000 b3ed1000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ee2000 b3ee4000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ef4000 b3ef6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f07000 b3f0c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f23000 b3f25000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f35000 b3f3c000 r-xp /usr/lib/libsensord-share.so
b3f4c000 b3f64000 r-xp /usr/lib/libsensor.so.1.1.0
b3f75000 b3f78000 r-xp /usr/lib/libXv.so.1.0.0
b3f88000 b3f8d000 r-xp /usr/lib/libutilX.so.1.1.0
b3f9d000 b3fa2000 r-xp /usr/lib/libappcore-common.so.1.1
b3fb2000 b3fb9000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fcc000 b3fd0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fe1000 b40bf000 r-xp /usr/lib/libCOREGL.so.4.0
b40df000 b40e2000 r-xp /usr/lib/libuuid.so.1.3.0
b40f2000 b4109000 r-xp /usr/lib/libblkid.so.1.1.0
b411a000 b411c000 r-xp /usr/lib/libXau.so.6.0.0
b412c000 b4173000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4185000 b418b000 r-xp /usr/lib/libjson-c.so.2.0.1
b419c000 b41a0000 r-xp /usr/lib/libogg.so.0.7.1
b41b0000 b41d2000 r-xp /usr/lib/libvorbis.so.0.4.3
b41e2000 b42c6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42e2000 b42e5000 r-xp /usr/lib/libEGL.so.1.4
b42f6000 b42fc000 r-xp /usr/lib/libxcb-render.so.0.0.0
b430c000 b430e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b431e000 b432b000 r-xp /usr/lib/libGLESv2.so.2.0
b433c000 b439e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43b3000 b43cb000 r-xp /usr/lib/libmount.so.1.1.0
b43dd000 b43f1000 r-xp /usr/lib/libxcb.so.1.1.0
b4401000 b4408000 r-xp /lib/libcrypt-2.20-2014.11.so
b4440000 b4442000 r-xp /usr/lib/libiri.so
b4452000 b445d000 r-xp /usr/lib/libgpg-error.so.0.15.0
b446e000 b44a4000 r-xp /usr/lib/libpulse.so.0.16.2
b44b5000 b44f8000 r-xp /usr/lib/libsndfile.so.1.0.25
b450d000 b4522000 r-xp /lib/libexpat.so.1.5.2
b4534000 b45f2000 r-xp /usr/lib/libcairo.so.2.11200.14
b4606000 b460e000 r-xp /usr/lib/libdrm.so.2.4.0
b461e000 b4621000 r-xp /usr/lib/libdri2.so.0.0.0
b4631000 b467f000 r-xp /usr/lib/libssl.so.1.0.0
b4694000 b46a0000 r-xp /usr/lib/libeeze.so.1.13.0
b46b1000 b46ba000 r-xp /usr/lib/libethumb.so.1.13.0
b46ca000 b46cd000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46dd000 b4894000 r-xp /usr/lib/libcrypto.so.1.0.0
b567f000 b5688000 r-xp /usr/lib/libXi.so.6.1.0
b5698000 b569a000 r-xp /usr/lib/libXgesture.so.7.0.0
b56aa000 b56ae000 r-xp /usr/lib/libXtst.so.6.1.0
b56be000 b56c4000 r-xp /usr/lib/libXrender.so.1.3.0
b56d4000 b56da000 r-xp /usr/lib/libXrandr.so.2.2.0
b56ea000 b56ec000 r-xp /usr/lib/libXinerama.so.1.0.0
b56fd000 b5700000 r-xp /usr/lib/libXfixes.so.3.1.0
b5710000 b571b000 r-xp /usr/lib/libXext.so.6.4.0
b572b000 b572d000 r-xp /usr/lib/libXdamage.so.1.1.0
b573d000 b573f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b574f000 b5831000 r-xp /usr/lib/libX11.so.6.3.0
b5845000 b584c000 r-xp /usr/lib/libXcursor.so.1.0.2
b585c000 b5874000 r-xp /usr/lib/libudev.so.1.6.0
b5876000 b5879000 r-xp /lib/libattr.so.1.1.0
b5889000 b58a9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58aa000 b58af000 r-xp /usr/lib/libffi.so.6.0.2
b58c0000 b58d8000 r-xp /lib/libz.so.1.2.8
b58e8000 b58ea000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58fa000 b59cf000 r-xp /usr/lib/libxml2.so.2.9.2
b59e4000 b5a7f000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a9b000 b5a9e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aae000 b5ac7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad8000 b5ae9000 r-xp /lib/libresolv-2.20-2014.11.so
b5afd000 b5b77000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b8c000 b5b8e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b9e000 b5ba5000 r-xp /usr/lib/libembryo.so.1.13.0
b5bb5000 b5bbf000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bd0000 b5be8000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf9000 b5c1c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c3d000 b5c51000 r-xp /usr/lib/libector.so.1.13.0
b5c62000 b5c7a000 r-xp /usr/lib/liblua-5.1.so
b5c8b000 b5ce2000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf6000 b5d1e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d2f000 b5d42000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d53000 b5d8d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d9e000 b5dac000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dbc000 b5dc4000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd4000 b5de1000 r-xp /usr/lib/libeio.so.1.13.0
b5df1000 b5df3000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e03000 b5e08000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e18000 b5e2f000 r-xp /usr/lib/libefreet.so.1.13.0
b5e41000 b5e61000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e71000 b5e91000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e93000 b5e99000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea9000 b5eba000 r-xp /usr/lib/libemotion.so.1.13.0
b5ecb000 b5ed2000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee2000 b5ef1000 r-xp /usr/lib/libeo.so.1.13.0
b5f02000 b5f14000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f25000 b5f2a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f3a000 b5f53000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f63000 b5f80000 r-xp /usr/lib/libeet.so.1.13.0
b5f99000 b5fe1000 r-xp /usr/lib/libeina.so.1.13.0
b5ff2000 b6002000 r-xp /usr/lib/libefl.so.1.13.0
b6013000 b60f8000 r-xp /usr/lib/libicuuc.so.51.1
b6115000 b6255000 r-xp /usr/lib/libicui18n.so.51.1
b626c000 b62a4000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b6000 b62b9000 r-xp /lib/libcap.so.2.21
b62c9000 b62f2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6303000 b630a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b631c000 b6353000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6364000 b644f000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6462000 b64db000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ed000 b64f2000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6502000 b650c000 r-xp /usr/lib/libvconf.so.0.2.45
b651c000 b651e000 r-xp /usr/lib/libvasum.so.0.3.1
b652e000 b6530000 r-xp /usr/lib/libttrace.so.1.1
b6540000 b6543000 r-xp /usr/lib/libiniparser.so.0
b6553000 b6578000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6589000 b658e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b659f000 b65b6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c7000 b6632000 r-xp /lib/libm-2.20-2014.11.so
b6643000 b6649000 r-xp /lib/librt-2.20-2014.11.so
b665a000 b6667000 r-xp /usr/lib/libunwind.so.8.0.1
b669d000 b67c1000 r-xp /lib/libc-2.20-2014.11.so
b67d6000 b67ef000 r-xp /lib/libgcc_s-4.9.so.1
b67ff000 b68e1000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f2000 b691c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b692d000 b6969000 r-xp /usr/lib/libsystemd.so.0.4.0
b696b000 b69ee000 r-xp /usr/lib/libedje.so.1.13.0
b6a01000 b6a1f000 r-xp /usr/lib/libecore.so.1.13.0
b6a3f000 b6bc6000 r-xp /usr/lib/libevas.so.1.13.0
b6bfb000 b6c0f000 r-xp /lib/libpthread-2.20-2014.11.so
b6c23000 b6e57000 r-xp /usr/lib/libelementary.so.1.13.0
b6e86000 b6e8a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e9a000 b6ea1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb1000 b6eb3000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec3000 b6ec6000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed6000 b6ed8000 r-xp /lib/libdl-2.20-2014.11.so
b6ee9000 b6f01000 r-xp /usr/lib/libaul.so.0.1.0
b6f15000 b6f1a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f2b000 b6f38000 r-xp /usr/lib/liblptcp.so
b6f4a000 b6f4e000 r-xp /usr/lib/libsys-assert.so
b6f5f000 b6f7f000 r-xp /lib/ld-2.20-2014.11.so
b6f90000 b6f95000 r-xp /usr/bin/launchpad-loader
b7586000 b78c1000 rw-p [heap]
befdd000 beffe000 rw-p [stack]
b7586000 b78c1000 rw-p [heap]
befdd000 beffe000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9900)
Call Stack Count: 1
 0: strlen + 0x23 (0xb67130e4) [/lib/libc.so.6] + 0x760e4
End of Call Stack

Package Information
Package Name: org.example.calculator
Package ID : org.example.calculator
Version: 1.0.0
Package Type: tpk
App Name: calculator
App ID: org.example.calculator
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 Done
03-20 17:06:00.733+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=1, ret=0x0
03-20 17:06:00.733+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:06:00.733+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
03-20 17:06:00.733+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
03-20 17:06:00.733+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: fg
03-20 17:06:00.743+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=1, ret=0x0
03-20 17:06:00.743+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:06:00.743+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:06:00.763+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:00.763+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:00.793+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30718661
03-20 17:06:00.793+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
03-20 17:06:00.793+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30718720
03-20 17:06:00.793+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
03-20 17:06:00.913+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30718792
03-20 17:06:00.913+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
03-20 17:06:00.913+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30718856
03-20 17:06:00.913+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
03-20 17:06:00.963+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(195) > ""
03-20 17:06:00.963+0900 E/UXT     (  714): uxt_date_time.c: uxt_date_time_get_format_by_locale(244) > format : %Y/%m/%d%p%l:%M
03-20 17:06:00.963+0900 E/UXT     (  714): uxt_util.c: uxt_util_get_date_time_text_by_locale(390) > text : 오후 5:06
03-20 17:06:00.963+0900 I/INDICATOR(  714): clock.c: getTimeFormatted(176) > "time format : 오후 5:06"
03-20 17:06:00.963+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 5:06"
03-20 17:06:00.963+0900 W/INDICATOR(  714): clock.c: indicator_clock_changed_cb(272) > 
03-20 17:06:00.963+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145430310 Time: <font_size=31> </font_size> <font_size=31> 오후 5:06</font_size></font>"
03-20 17:06:01.063+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30718928
03-20 17:06:01.063+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
03-20 17:06:01.063+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30719005
03-20 17:06:01.063+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
03-20 17:06:01.714+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30719650
03-20 17:06:01.744+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
03-20 17:06:01.744+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
03-20 17:06:01.754+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.754+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.764+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
03-20 17:06:01.764+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
03-20 17:06:01.764+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: bg
03-20 17:06:01.774+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.774+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.784+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.784+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.794+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30719736
03-20 17:06:01.804+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.804+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.814+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.824+0900 I/APP_CORE( 9604): appcore-efl.c: __do_app(514) > [APP 9604] Event: MEM_FLUSH State: PAUSED
03-20 17:06:01.824+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.834+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.844+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.854+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.854+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.874+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.874+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.894+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.894+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.914+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.914+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.914+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.914+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.934+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.934+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:01.944+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:01.954+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:03.065+0900 W/MEDIA_THUMBNAIL_SERVER( 9922): thumb-server-internal.c: _thumb_server_read_socket(514) > [32mreceived KILL msg from thumbnail agent.
03-20 17:06:03.065+0900 W/MEDIA_THUMBNAIL_SERVER( 9922): thumb-server-internal.c: _thumb_server_read_socket(575) > [32mShutting down...
03-20 17:06:03.065+0900 E/MEDIA_THUMBNAIL_DCM( 9922): thumb-server-dcm.c: _thumb_server_dcm_quit_main_loop(445) > [31mInvalid DCM thread main loop![0m
03-20 17:06:03.245+0900 E/MEDIA_SERVER(  899): media-server-main.c: _ms_signal_handler(183) > [9922] Thumbnail server is stopped by media-server
03-20 17:06:03.245+0900 E/MEDIA_SERVER_THUMB(  899): media-server-thumb.c: ms_thumb_reset_server_status(162) > [no-err] g_thumb_server_extracting = 0 -> FALSE
03-20 17:06:04.977+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30722916
03-20 17:06:05.087+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30723024
03-20 17:06:05.357+0900 W/cluster-view(  851): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
03-20 17:06:05.617+0900 I/APP_CORE( 8537): appcore-efl.c: __do_app(514) > [APP 8537] Event: MEM_FLUSH State: PAUSED
03-20 17:06:05.998+0900 E/AUL_AMD (  629): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
03-20 17:06:06.158+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30724095
03-20 17:06:06.218+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30724159
03-20 17:06:06.218+0900 W/AUL     (  851): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.calculator)
03-20 17:06:06.218+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 1
03-20 17:06:06.218+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(2508) > caller pid : 851
03-20 17:06:06.228+0900 W/AUL     (  629): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 9604, appid: org.example.calculator
03-20 17:06:06.228+0900 W/AUL_AMD (  629): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 1, pid: 9604
03-20 17:06:06.228+0900 W/AUL_AMD (  629): amd_launch.c: _resume_app(924) > resume done
03-20 17:06:06.238+0900 W/AUL_AMD (  629): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(9604), cmd(3)
03-20 17:06:06.238+0900 W/AUL     (  851): launch.c: app_request_to_launchpad(425) > request cmd(1) result(9604)
03-20 17:06:06.248+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(9604) status(3)
03-20 17:06:06.248+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.calculator(9604)
03-20 17:06:06.248+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9604, appid: org.example.calculator, status: fg
03-20 17:06:06.278+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(9604) status(0)
03-20 17:06:06.308+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:06.308+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:06.318+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: PAUSE State: RUNNING
03-20 17:06:06.318+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
03-20 17:06:06.318+0900 E/cluster-home(  851): homescreen.cpp: OnPause(260) >  app pause
03-20 17:06:06.318+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(4)
03-20 17:06:06.318+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(851)
03-20 17:06:06.318+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: bg
03-20 17:06:06.328+0900 I/APP_CORE( 9604): appcore-efl.c: __do_app(514) > [APP 9604] Event: RESUME State: PAUSED
03-20 17:06:06.328+0900 I/CAPI_APPFW_APPLICATION( 9604): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:06:06.338+0900 I/Tizen::System( 1243): (259) > Active app [org.exampl], current [com.samsun] 
03-20 17:06:06.338+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:06:06.338+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:06:06.348+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:06:06.668+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(9604) status(0)
03-20 17:06:08.550+0900 E/STARTER (  736): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
03-20 17:06:08.550+0900 E/STARTER (  736): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
03-20 17:06:08.550+0900 E/STARTER (  736): )
03-20 17:06:09.371+0900 E/EFL     ( 9604): ecore_x<9604> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30727312
03-20 17:06:09.371+0900 E/EFL     (  861): ecore_x<861> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30727312
03-20 17:06:09.371+0900 W/STARTER (  736): hw_key.c: _key_press_cb(760) > [_key_press_cb:760] Home Key is pressed
03-20 17:06:09.371+0900 W/STARTER (  736): hw_key.c: _key_press_cb(778) > [_key_press_cb:778] homekey count : 1
03-20 17:06:09.471+0900 W/STARTER (  736): hw_key.c: _key_release_cb(580) > [_key_release_cb:580] Home Key is released
03-20 17:06:09.471+0900 E/EFL     ( 9604): ecore_x<9604> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30727405
03-20 17:06:09.471+0900 E/EFL     ( 9604): ecore_x<9604> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30727405
03-20 17:06:09.471+0900 E/EFL     ( 9604): ecore_x<9604> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30727405
03-20 17:06:09.471+0900 E/EFL     (  861): ecore_x<861> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30727405
03-20 17:06:09.471+0900 E/EFL     (  861): ecore_x<861> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30727405
03-20 17:06:09.471+0900 E/EFL     (  861): ecore_x<861> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30727405
03-20 17:06:09.521+0900 E/STARTER (  736): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
03-20 17:06:09.521+0900 E/STARTER (  736): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
03-20 17:06:09.521+0900 E/STARTER (  736): )
03-20 17:06:09.731+0900 W/STARTER (  736): hw_key.c: _destroy_syspopup_cb(725) > [_destroy_syspopup_cb:725] cancel key is activated. Do not destroy syspopup
03-20 17:06:09.912+0900 E/VCONF   (  327): vconf.c: vconf_get_int(2657) > The type(43) of keynode(db/setting/sound/sound_on) is not INT
03-20 17:06:09.912+0900 W/MEDIA_SERVER_THUMB(  899): media-server-thumb.c: _ms_thumb_request_to_server(825) > Thumb server is not running.. so start it
03-20 17:06:10.162+0900 E/MEDIA_THUMBNAIL( 9931): media-thumb-db.c: _media_thumb_get_thumb_path_from_db(162) > [31mend of row [unknown error]
03-20 17:06:10.162+0900 W/MEDIA_THUMBNAIL( 9931): media-thumb-db.c: _media_thumb_get_thumb_from_db_with_size(408) > [32mOriginal path doesn't exist in DB
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(71) > On Media Content Data Changed
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(79) > Media Content Image Type Data Changed
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(332) > DataChangeSyncScheduler::HandleDataChangeEvent() Starts
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncManager.cpp: SendSyncCheckAlarmMessage(1018) > Fire SYNC_CHECK_ALARM 
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(137) > Adding a request to sync worker
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(152) > Added into __pendingRequests, current size = 1
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(164) > Request Successfully added
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(345) > DataChangeSyncScheduler::HandleDataChangeEvent() Ends
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(175) > GIO event received
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(201) > Popping from __pendingRequests, size = 0
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(127) > 0. Sync Job dispatcher starts
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(157) > 1. Handle Event : SYNC_CHECK_ALARM
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(158) > 2. Start next Sync job from main queue
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: TryStartingNextJobLocked(190) > No network available: Skipping sync
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(174) > 3. Sync Job dispatcher Ends
03-20 17:06:10.322+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(214) > Event handled successfully
03-20 17:06:10.742+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  327): media_content.c: media_content_connect(856) > [32m[327]ref count : 0
03-20 17:06:10.742+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  327): media_content.c: media_content_connect(888) > [32m[327]ref count changed to: 1
03-20 17:06:10.782+0900 W/MEDIA_THUMBNAIL( 9931): media-thumb-db.c: _media_thumb_get_thumb_from_db_with_size(413) > [32mthumb path doesn't exist in DB
03-20 17:06:10.943+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  327): media_content.c: media_content_disconnect(940) > [32m[327]ref count changed to: 0
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(71) > On Media Content Data Changed
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(79) > Media Content Image Type Data Changed
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(332) > DataChangeSyncScheduler::HandleDataChangeEvent() Starts
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncManager.cpp: SendSyncCheckAlarmMessage(1018) > Fire SYNC_CHECK_ALARM 
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(137) > Adding a request to sync worker
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(152) > Added into __pendingRequests, current size = 1
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(164) > Request Successfully added
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(345) > DataChangeSyncScheduler::HandleDataChangeEvent() Ends
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(175) > GIO event received
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(201) > Popping from __pendingRequests, size = 0
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(127) > 0. Sync Job dispatcher starts
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(157) > 1. Handle Event : SYNC_CHECK_ALARM
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(158) > 2. Start next Sync job from main queue
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: TryStartingNextJobLocked(190) > No network available: Skipping sync
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(174) > 3. Sync Job dispatcher Ends
03-20 17:06:10.943+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(214) > Event handled successfully
03-20 17:06:10.953+0900 I/AUL     (  327): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
03-20 17:06:10.953+0900 I/AUL     (  327): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
03-20 17:06:10.963+0900 I/AUL     (  327): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
03-20 17:06:10.973+0900 I/AUL     (  327): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
03-20 17:06:10.973+0900 E/CAPI_APPFW_APP_MANAGER(  327): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
03-20 17:06:10.983+0900 I/QUICKPANEL(  867): NotificationItemModel.cpp: __updateSmartAlert(2288) > [0;32mpackage name: shot-tizen, insert: 0[0;m
03-20 17:06:10.983+0900 I/QUICKPANEL(  867): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
03-20 17:06:10.983+0900 W/QUICKPANEL(  867): NotificationItemModel.cpp: removeNotification(286) > [0;35mEvent notification is deleted.[0;m
03-20 17:06:10.993+0900 I/QUICKPANEL(  867): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
03-20 17:06:11.003+0900 E/INDICATOR(  714): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
03-20 17:06:11.003+0900 E/INDICATOR(  714): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
03-20 17:06:11.003+0900 I/AUL     (  750): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
03-20 17:06:11.003+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:06:11.003+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:06:11.013+0900 I/AUL     (  750): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
03-20 17:06:11.023+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:06:11.023+0900 E/INDICATOR(  714): ticker.c: _ticker_noti_detailed_changed_cb(1335) > check op_type
03-20 17:06:11.023+0900 I/AUL     (  750): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
03-20 17:06:11.033+0900 I/AUL     (  750): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
03-20 17:06:11.033+0900 E/CAPI_APPFW_APP_MANAGER(  750): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
03-20 17:06:11.083+0900 E/QUICKPANEL(  867): NotificationItemModel.cpp: __playSound(1794) > [0;31m* Critical * None type: No sound[0;m
03-20 17:06:11.083+0900 I/QUICKPANEL(  867): NotificationItemModel.cpp: __updateSmartAlert(2288) > [0;32mpackage name: shot-tizen, insert: 1[0;m
03-20 17:06:11.103+0900 E/QUICKPANEL(  867): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
03-20 17:06:11.103+0900 E/QUICKPANEL(  867): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
03-20 17:06:11.103+0900 E/QUICKPANEL(  867): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
03-20 17:06:11.103+0900 W/QUICKPANEL(  867): NotificationItemModel.cpp: __addNotification(635) > [0;35mshot-tizen - notification is inserted.[0;m
03-20 17:06:11.113+0900 E/INDICATOR(  714): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
03-20 17:06:11.113+0900 E/INDICATOR(  714): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
03-20 17:06:11.123+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:06:11.123+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:06:11.123+0900 I/QUICKPANEL(  867): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
03-20 17:06:11.123+0900 W/QUICKPANEL(  867): NotificationItemModel.cpp: insertNotification(235) > [0;35mEvent notification is inserted.[0;m
03-20 17:06:11.123+0900 E/EFL     (  867): eo<867> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
03-20 17:06:11.123+0900 I/QUICKPANEL(  867): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
03-20 17:06:11.123+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:06:11.123+0900 E/INDICATOR(  714): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
03-20 17:06:11.143+0900 E/EFL     (  867): edje<867> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/listitem/notification has a non-fixed part 'elm.text.time'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
03-20 17:06:11.323+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: MEM_FLUSH State: PAUSED
03-20 17:06:13.966+0900 E/EFL     ( 9604): ecore_x<9604> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30731900
03-20 17:06:14.066+0900 E/EFL     ( 9604): ecore_x<9604> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30731998
03-20 17:06:14.096+0900 E/EFL     ( 9604): <9604> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
03-20 17:06:14.206+0900 I/AUL_PAD ( 1562): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9604 pgid = 9604
03-20 17:06:14.206+0900 I/AUL_PAD ( 1562): sigchild.h: __sigchild_action(143) > dead_pid(9604)
03-20 17:06:14.206+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:14.236+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(3)
03-20 17:06:14.236+0900 W/AUL_AMD (  629): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-20 17:06:14.236+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
03-20 17:06:14.236+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(851)
03-20 17:06:14.236+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: fg
03-20 17:06:14.276+0900 I/AUL_PAD ( 1562): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
03-20 17:06:14.276+0900 I/AUL_PAD ( 1562): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
03-20 17:06:14.276+0900 E/AUL_PAD ( 1562): launchpad.c: main(698) > error reading sigchld info
03-20 17:06:14.276+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
03-20 17:06:14.286+0900 I/Tizen::App( 1243): (243) > App[org.example.calculator] pid[9604] terminate event is forwarded
03-20 17:06:14.286+0900 I/Tizen::System( 1243): (256) > osp.accessorymanager.service provider is found.
03-20 17:06:14.286+0900 I/Tizen::System( 1243): (196) > Accessory Owner is removed [org.example.calculator, 9604, ]
03-20 17:06:14.286+0900 I/Tizen::System( 1243): (256) > osp.system.service provider is found.
03-20 17:06:14.286+0900 I/Tizen::App( 1243): (506) > TerminatedApp(org.example.calculator)
03-20 17:06:14.286+0900 I/Tizen::App( 1243): (512) > Not registered pid(9604)
03-20 17:06:14.286+0900 I/Tizen::System( 1243): (246) > Terminated app [org.example.calculator]
03-20 17:06:14.286+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:06:14.296+0900 I/ESD     (  905): esd_main.c: __esd_app_dead_handler(1773) > pid: 9604
03-20 17:06:14.296+0900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9604
03-20 17:06:14.296+0900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9604
03-20 17:06:14.296+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: RESUME State: PAUSED
03-20 17:06:14.296+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:06:14.296+0900 E/cluster-home(  851): homescreen.cpp: OnResume(233) >  app resume
03-20 17:06:14.296+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:14.306+0900 E/RESOURCED(  718): datausage-common.c: app_terminated_cb(643) > No classid to terminate!
03-20 17:06:14.306+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:06:14.306+0900 I/Tizen::App( 1243): (782) > Finished invoking application event listener for org.example.calculator, 9604.
03-20 17:06:14.326+0900 I/Tizen::System( 1243): (259) > Active app [com.samsun], current [org.exampl] 
03-20 17:06:14.326+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:06:14.346+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
03-20 17:06:14.356+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
03-20 17:06:14.356+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: fg
03-20 17:06:14.366+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=1, ret=0x0
03-20 17:06:14.366+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:06:14.366+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:14.366+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=1, ret=0x0
03-20 17:06:14.366+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:06:14.366+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:14.366+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:06:14.366+0900 W/CRASH_MANAGER( 9941): worker.c: worker_job(1199) > 110960463616c1458461174
03-20 17:06:14.416+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:06:15.367+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.367+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.387+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.387+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.407+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.407+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.417+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.427+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.437+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.437+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.457+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.457+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.477+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.477+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.497+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.497+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.507+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.517+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.527+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.537+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.547+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.547+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.547+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.557+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:15.567+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:15.567+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:16.058+0900 W/MEDIA_THUMBNAIL_SERVER( 9931): thumb-server-internal.c: _thumb_server_read_socket(514) > [32mreceived KILL msg from thumbnail agent.
03-20 17:06:16.058+0900 W/MEDIA_THUMBNAIL_SERVER( 9931): thumb-server-internal.c: _thumb_server_read_socket(575) > [32mShutting down...
03-20 17:06:16.058+0900 E/MEDIA_THUMBNAIL_DCM( 9931): thumb-server-dcm.c: _thumb_server_dcm_quit_main_loop(445) > [31mInvalid DCM thread main loop![0m
03-20 17:06:16.198+0900 E/MEDIA_SERVER(  899): media-server-main.c: _ms_signal_handler(183) > [9931] Thumbnail server is stopped by media-server
03-20 17:06:16.198+0900 E/MEDIA_SERVER_THUMB(  899): media-server-thumb.c: ms_thumb_reset_server_status(162) > [no-err] g_thumb_server_extracting = 0 -> FALSE
03-20 17:06:16.388+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30734333
03-20 17:06:16.448+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30734397
03-20 17:06:16.458+0900 W/AUL     (  851): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.calculator)
03-20 17:06:16.458+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 1
03-20 17:06:16.458+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(2508) > caller pid : 851
03-20 17:06:16.468+0900 E/RESOURCED(  718): block.c: block_prelaunch_state(134) > insert data org.example.calculator, table num : 11
03-20 17:06:16.468+0900 E/RESOURCED(  718): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
03-20 17:06:16.468+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(3052) > pad pid(-5)
03-20 17:06:16.468+0900 W/AUL_PAD ( 1562): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
03-20 17:06:16.468+0900 W/AUL_PAD ( 1562): launchpad.c: __send_result_to_caller(267) > Check app launching
03-20 17:06:16.488+0900 I/CAPI_APPFW_APPLICATION( 9900): app_main.c: ui_app_main(789) > app_efl_main
03-20 17:06:16.488+0900 I/CAPI_APPFW_APPLICATION( 9900): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
03-20 17:06:16.518+0900 E/TBM     ( 9900): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
03-20 17:06:16.568+0900 W/AUL     (  629): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9900, appid: org.example.calculator
03-20 17:06:16.568+0900 E/AUL     (  629): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
03-20 17:06:16.568+0900 E/RESOURCED(  718): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.calculator
03-20 17:06:16.578+0900 W/AUL     (  851): launch.c: app_request_to_launchpad(425) > request cmd(1) result(9900)
03-20 17:06:16.808+0900 I/APP_CORE( 9900): appcore-efl.c: __do_app(514) > [APP 9900] Event: RESET State: CREATED
03-20 17:06:16.808+0900 I/CAPI_APPFW_APPLICATION( 9900): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
03-20 17:06:16.808+0900 E/EFL     ( 9900): edje<9900> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:16.808+0900 E/EFL     ( 9900): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:16.818+0900 E/EFL     ( 9900): edje<9900> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:16.818+0900 E/EFL     ( 9900): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:16.818+0900 E/EFL     ( 9900): edje<9900> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:16.818+0900 E/EFL     ( 9900): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:16.818+0900 E/EFL     ( 9900): edje<9900> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:16.818+0900 E/EFL     ( 9900): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:16.818+0900 E/EFL     ( 9900): edje<9900> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:16.818+0900 E/EFL     ( 9900): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:16.848+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:16.848+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:16.868+0900 I/Tizen::System( 1243): (259) > Active app [org.exampl], current [com.samsun] 
03-20 17:06:16.868+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:06:16.868+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:06:16.878+0900 W/APP_CORE( 9900): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
03-20 17:06:16.878+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 35
03-20 17:06:16.898+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:06:16.928+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: PAUSE State: RUNNING
03-20 17:06:16.928+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
03-20 17:06:16.928+0900 E/cluster-home(  851): homescreen.cpp: OnPause(260) >  app pause
03-20 17:06:16.928+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(4)
03-20 17:06:16.928+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(851)
03-20 17:06:16.928+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: bg
03-20 17:06:16.938+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(9900) status(3)
03-20 17:06:16.938+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
03-20 17:06:16.938+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
03-20 17:06:16.938+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: bg
03-20 17:06:16.938+0900 I/APP_CORE( 9900): appcore-efl.c: __do_app(514) > [APP 9900] Event: RESUME State: CREATED
03-20 17:06:16.938+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.calculator(9900)
03-20 17:06:16.938+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9900, appid: org.example.calculator, status: fg
03-20 17:06:16.958+0900 I/APP_CORE( 9900): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
03-20 17:06:16.958+0900 I/APP_CORE( 9900): appcore-efl.c: __do_app(625) > [APP 9900] Initial Launching, call the resume_cb
03-20 17:06:16.958+0900 I/CAPI_APPFW_APPLICATION( 9900): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:06:17.299+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(9900) status(0)
03-20 17:06:17.599+0900 E/RESOURCED(  718): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.868
03-20 17:06:17.609+0900 I/Tizen::App( 1243): (499) > LaunchedApp(org.example.calculator)
03-20 17:06:17.609+0900 I/Tizen::App( 1243): (733) > Finished invoking application event listener for org.example.calculator, 9900.
03-20 17:06:18.400+0900 I/UXT     ( 9961): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
03-20 17:06:20.122+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30738059
03-20 17:06:20.202+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30738135
03-20 17:06:20.202+0900 E/VCONF   ( 9900): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
03-20 17:06:20.202+0900 E/VCONF   ( 9900): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
03-20 17:06:20.202+0900 E/VCONF   ( 9900): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
03-20 17:06:20.202+0900 E/VCONF   ( 9900): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9900) : db/ise/keysound error
03-20 17:06:20.202+0900 E/VCONF   ( 9900): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
03-20 17:06:20.202+0900 E/VCONF   ( 9900): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
03-20 17:06:20.342+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30738287
03-20 17:06:20.422+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30738362
03-20 17:06:20.562+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30738504
03-20 17:06:20.652+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30738590
03-20 17:06:20.792+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30738732
03-20 17:06:20.902+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30738839
03-20 17:06:21.283+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30739215
03-20 17:06:21.373+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30739312
03-20 17:06:21.503+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30739443
03-20 17:06:21.593+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30739529
03-20 17:06:21.693+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30739638
03-20 17:06:21.783+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30739724
03-20 17:06:21.933+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: MEM_FLUSH State: PAUSED
03-20 17:06:22.073+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30740009
03-20 17:06:22.164+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30740105
03-20 17:06:22.944+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30740879
03-20 17:06:23.024+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30740966
03-20 17:06:23.175+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30741118
03-20 17:06:23.255+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30741194
03-20 17:06:23.455+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30741389
03-20 17:06:23.515+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30741454
03-20 17:06:25.887+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30743821
03-20 17:06:25.957+0900 E/EFL     ( 9900): ecore_x<9900> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30743897
03-20 17:06:25.967+0900 E/EFL     ( 9900): <9900> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
03-20 17:06:26.087+0900 W/CRASH_MANAGER( 9941): worker.c: worker_job(1199) > 110990063616c145846118
