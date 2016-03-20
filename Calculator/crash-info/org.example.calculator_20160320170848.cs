S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDU0BOL4
Build-Date: 2015.12.24 17:18:01

Crash Information
Process Name: calculator
PID: 10373
Date: 2016-03-20 17:08:48+0900
Executable File Path: /opt/usr/apps/org.example.calculator/bin/calculator
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10373, uid 5000)

Register Information
r0   = 0xfffffff8, r1   = 0x00000000
r2   = 0xca6e3e00, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb8b32b28
r6   = 0xb8b297a8, r7   = 0xbee891f0
r8   = 0x800148a5, r9   = 0xb5eb4708
r10  = 0xb8b1ba28, fp   = 0xb5f8d640
ip   = 0xffffffff, sp   = 0xbee891b8
lr   = 0xb27c8a3d, pc   = 0xb66c60e4
cpsr = 0x600b0030

Memory Information
MemTotal:   987012 KB
MemFree:     73832 KB
Buffers:     52568 KB
Cached:     335464 KB
VmPeak:     125468 KB
VmSize:     125464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22652 KB
VmRSS:       22652 KB
VmData:      41488 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35696 KB
VmPTE:          90 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10373 TID = 10373
10373 10374 10406 10407 10410 

Maps Information
afa81000 b0280000 rw-p [stack:10410]
b12ed000 b1aec000 rw-p [stack:10407]
b1b2f000 b1b40000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b50000 b1b55000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1b65000 b1b6d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b7e000 b1b7f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b8f000 b1ba3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bb7000 b1bb8000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bc8000 b1bcb000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bdc000 b1bdd000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bed000 b1bef000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bff000 b1c01000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c11000 b1c21000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c31000 b1c3d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c4f000 b244e000 rw-p [stack:10406]
b277f000 b2786000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2797000 b279f000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27b1000 b27b7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27c7000 b27c9000 r-xp /opt/usr/apps/org.example.calculator/bin/calculator
b2919000 b29fc000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a33000 b2a5b000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a6d000 b326c000 rw-p [stack:10374]
b326c000 b326e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b327e000 b3288000 r-xp /lib/libnss_files-2.20-2014.11.so
b3299000 b32a2000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32b3000 b32c4000 r-xp /lib/libnsl-2.20-2014.11.so
b32d7000 b32dd000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32ee000 b32ef000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3317000 b331e000 r-xp /usr/lib/libminizip.so.1.0.0
b332e000 b3333000 r-xp /usr/lib/libstorage.so.0.1
b3343000 b33a2000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33b8000 b33cc000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33dc000 b3420000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3430000 b3438000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3448000 b3478000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b348b000 b3544000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3558000 b35ab000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35bc000 b35d7000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35e7000 b36a8000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36bb000 b36cb000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36db000 b36e8000 r-xp /usr/lib/libmdm-common.so.1.0.97
b36f9000 b3700000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3710000 b3751000 r-xp /usr/lib/libmdm.so.1.2.12
b3761000 b3769000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3778000 b3788000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37a9000 b3809000 r-xp /usr/lib/libasound.so.2.0.0
b381b000 b381e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b382e000 b3831000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3841000 b3846000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3856000 b3857000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3867000 b3871000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3885000 b388c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b389c000 b38a2000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38b2000 b38b7000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38c7000 b38e1000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38f2000 b38f9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3909000 b390c000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b391d000 b394b000 r-xp /usr/lib/libidn.so.11.5.44
b395b000 b3971000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3982000 b398c000 r-xp /usr/lib/libcares.so.2.1.0
b399c000 b39a6000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b39b6000 b39b8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39c8000 b39c9000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39d9000 b39dd000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39ee000 b3a16000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a27000 b3a50000 r-xp /usr/lib/libturbojpeg.so
b3a70000 b3a76000 r-xp /usr/lib/libgif.so.4.1.6
b3a86000 b3acc000 r-xp /usr/lib/libcurl.so.4.3.0
b3add000 b3afe000 r-xp /usr/lib/libexif.so.12.3.3
b3b19000 b3b2e000 r-xp /usr/lib/libtts.so
b3b3f000 b3b47000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b57000 b3c1d000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c3d000 b3d35000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d54000 b3e22000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e39000 b3e3b000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e4b000 b3e51000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e61000 b3e84000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e95000 b3e97000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ea7000 b3ea9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3eba000 b3ebf000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ed6000 b3ed8000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ee8000 b3eef000 r-xp /usr/lib/libsensord-share.so
b3eff000 b3f17000 r-xp /usr/lib/libsensor.so.1.1.0
b3f28000 b3f2b000 r-xp /usr/lib/libXv.so.1.0.0
b3f3b000 b3f40000 r-xp /usr/lib/libutilX.so.1.1.0
b3f50000 b3f55000 r-xp /usr/lib/libappcore-common.so.1.1
b3f65000 b3f6c000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f7f000 b3f83000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f94000 b4072000 r-xp /usr/lib/libCOREGL.so.4.0
b4092000 b4095000 r-xp /usr/lib/libuuid.so.1.3.0
b40a5000 b40bc000 r-xp /usr/lib/libblkid.so.1.1.0
b40cd000 b40cf000 r-xp /usr/lib/libXau.so.6.0.0
b40df000 b4126000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4138000 b413e000 r-xp /usr/lib/libjson-c.so.2.0.1
b414f000 b4153000 r-xp /usr/lib/libogg.so.0.7.1
b4163000 b4185000 r-xp /usr/lib/libvorbis.so.0.4.3
b4195000 b4279000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4295000 b4298000 r-xp /usr/lib/libEGL.so.1.4
b42a9000 b42af000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42bf000 b42c1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42d1000 b42de000 r-xp /usr/lib/libGLESv2.so.2.0
b42ef000 b4351000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4366000 b437e000 r-xp /usr/lib/libmount.so.1.1.0
b4390000 b43a4000 r-xp /usr/lib/libxcb.so.1.1.0
b43b4000 b43bb000 r-xp /lib/libcrypt-2.20-2014.11.so
b43f3000 b43f5000 r-xp /usr/lib/libiri.so
b4405000 b4410000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4421000 b4457000 r-xp /usr/lib/libpulse.so.0.16.2
b4468000 b44ab000 r-xp /usr/lib/libsndfile.so.1.0.25
b44c0000 b44d5000 r-xp /lib/libexpat.so.1.5.2
b44e7000 b45a5000 r-xp /usr/lib/libcairo.so.2.11200.14
b45b9000 b45c1000 r-xp /usr/lib/libdrm.so.2.4.0
b45d1000 b45d4000 r-xp /usr/lib/libdri2.so.0.0.0
b45e4000 b4632000 r-xp /usr/lib/libssl.so.1.0.0
b4647000 b4653000 r-xp /usr/lib/libeeze.so.1.13.0
b4664000 b466d000 r-xp /usr/lib/libethumb.so.1.13.0
b467d000 b4680000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4690000 b4847000 r-xp /usr/lib/libcrypto.so.1.0.0
b5632000 b563b000 r-xp /usr/lib/libXi.so.6.1.0
b564b000 b564d000 r-xp /usr/lib/libXgesture.so.7.0.0
b565d000 b5661000 r-xp /usr/lib/libXtst.so.6.1.0
b5671000 b5677000 r-xp /usr/lib/libXrender.so.1.3.0
b5687000 b568d000 r-xp /usr/lib/libXrandr.so.2.2.0
b569d000 b569f000 r-xp /usr/lib/libXinerama.so.1.0.0
b56b0000 b56b3000 r-xp /usr/lib/libXfixes.so.3.1.0
b56c3000 b56ce000 r-xp /usr/lib/libXext.so.6.4.0
b56de000 b56e0000 r-xp /usr/lib/libXdamage.so.1.1.0
b56f0000 b56f2000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5702000 b57e4000 r-xp /usr/lib/libX11.so.6.3.0
b57f8000 b57ff000 r-xp /usr/lib/libXcursor.so.1.0.2
b580f000 b5827000 r-xp /usr/lib/libudev.so.1.6.0
b5829000 b582c000 r-xp /lib/libattr.so.1.1.0
b583c000 b585c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b585d000 b5862000 r-xp /usr/lib/libffi.so.6.0.2
b5873000 b588b000 r-xp /lib/libz.so.1.2.8
b589b000 b589d000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58ad000 b5982000 r-xp /usr/lib/libxml2.so.2.9.2
b5997000 b5a32000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a4e000 b5a51000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a61000 b5a7a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a8b000 b5a9c000 r-xp /lib/libresolv-2.20-2014.11.so
b5ab0000 b5b2a000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b3f000 b5b41000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b51000 b5b58000 r-xp /usr/lib/libembryo.so.1.13.0
b5b68000 b5b72000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b83000 b5b9b000 r-xp /usr/lib/libpng12.so.0.50.0
b5bac000 b5bcf000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bf0000 b5c04000 r-xp /usr/lib/libector.so.1.13.0
b5c15000 b5c2d000 r-xp /usr/lib/liblua-5.1.so
b5c3e000 b5c95000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ca9000 b5cd1000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ce2000 b5cf5000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d06000 b5d40000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d51000 b5d5f000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d6f000 b5d77000 r-xp /usr/lib/libtbm.so.1.0.0
b5d87000 b5d94000 r-xp /usr/lib/libeio.so.1.13.0
b5da4000 b5da6000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5db6000 b5dbb000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dcb000 b5de2000 r-xp /usr/lib/libefreet.so.1.13.0
b5df4000 b5e14000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e24000 b5e44000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e46000 b5e4c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e5c000 b5e6d000 r-xp /usr/lib/libemotion.so.1.13.0
b5e7e000 b5e85000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e95000 b5ea4000 r-xp /usr/lib/libeo.so.1.13.0
b5eb5000 b5ec7000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ed8000 b5edd000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eed000 b5f06000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f16000 b5f33000 r-xp /usr/lib/libeet.so.1.13.0
b5f4c000 b5f94000 r-xp /usr/lib/libeina.so.1.13.0
b5fa5000 b5fb5000 r-xp /usr/lib/libefl.so.1.13.0
b5fc6000 b60ab000 r-xp /usr/lib/libicuuc.so.51.1
b60c8000 b6208000 r-xp /usr/lib/libicui18n.so.51.1
b621f000 b6257000 r-xp /usr/lib/libecore_x.so.1.13.0
b6269000 b626c000 r-xp /lib/libcap.so.2.21
b627c000 b62a5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62b6000 b62bd000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62cf000 b6306000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6317000 b6402000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6415000 b648e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64a0000 b64a5000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64b5000 b64bf000 r-xp /usr/lib/libvconf.so.0.2.45
b64cf000 b64d1000 r-xp /usr/lib/libvasum.so.0.3.1
b64e1000 b64e3000 r-xp /usr/lib/libttrace.so.1.1
b64f3000 b64f6000 r-xp /usr/lib/libiniparser.so.0
b6506000 b652b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b653c000 b6541000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6552000 b6569000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b657a000 b65e5000 r-xp /lib/libm-2.20-2014.11.so
b65f6000 b65fc000 r-xp /lib/librt-2.20-2014.11.so
b660d000 b661a000 r-xp /usr/lib/libunwind.so.8.0.1
b6650000 b6774000 r-xp /lib/libc-2.20-2014.11.so
b6789000 b67a2000 r-xp /lib/libgcc_s-4.9.so.1
b67b2000 b6894000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68a5000 b68cf000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68e0000 b691c000 r-xp /usr/lib/libsystemd.so.0.4.0
b691e000 b69a1000 r-xp /usr/lib/libedje.so.1.13.0
b69b4000 b69d2000 r-xp /usr/lib/libecore.so.1.13.0
b69f2000 b6b79000 r-xp /usr/lib/libevas.so.1.13.0
b6bae000 b6bc2000 r-xp /lib/libpthread-2.20-2014.11.so
b6bd6000 b6e0a000 r-xp /usr/lib/libelementary.so.1.13.0
b6e39000 b6e3d000 r-xp /usr/lib/libsmack.so.1.0.0
b6e4d000 b6e54000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e64000 b6e66000 r-xp /usr/lib/libdlog.so.0.0.0
b6e76000 b6e79000 r-xp /usr/lib/libbundle.so.0.1.22
b6e89000 b6e8b000 r-xp /lib/libdl-2.20-2014.11.so
b6e9c000 b6eb4000 r-xp /usr/lib/libaul.so.0.1.0
b6ec8000 b6ecd000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ede000 b6eeb000 r-xp /usr/lib/liblptcp.so
b6efd000 b6f01000 r-xp /usr/lib/libsys-assert.so
b6f12000 b6f32000 r-xp /lib/ld-2.20-2014.11.so
b6f43000 b6f48000 r-xp /usr/bin/launchpad-loader
b88c9000 b8c04000 rw-p [heap]
bee69000 bee8a000 rw-p [stack]
b88c9000 b8c04000 rw-p [heap]
bee69000 bee8a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10373)
Call Stack Count: 1
 0: strlen + 0x23 (0xb66c60e4) [/lib/libc.so.6] + 0x760e4
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
culator errno: 2 (No such file or directory)[0;m
03-20 17:08:18.737+0900 E/PKGMGR  (10248): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[102480002]
03-20 17:08:18.887+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: start, val: update
03-20 17:08:18.887+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [start], Value = [update], install = [96]
03-20 17:08:18.887+0900 W/AUL_AMD (  629): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
03-20 17:08:18.887+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: install_percent, val: 30
03-20 17:08:18.887+0900 I/Tizen::App( 1243): (119) > InstallationInProgress [30]
03-20 17:08:18.887+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [install_percent], Value = [30], install = [96]
03-20 17:08:19.018+0900 E/rpm-installer(10253): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
03-20 17:08:19.018+0900 E/rpm-installer(10253): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1569) > (pkg_file_info == NULL) pkg_file_info is NULL.
03-20 17:08:19.068+0900 E/PKGMGR_PARSER(10253): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
03-20 17:08:19.088+0900 E/PKGMGR_CERT(10253): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
03-20 17:08:19.088+0900 E/PKGMGR_CERT(10253): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
03-20 17:08:19.098+0900 E/PKGMGR_CERT(10253): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
03-20 17:08:19.128+0900 E/rpm-installer(10253): coretpk-installer.c: _coretpk_installer_package_reinstall(6322) > _coretpk_installer_package_reinstall(org.example.calculator) failed.
03-20 17:08:19.128+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: end, val: fail
03-20 17:08:19.128+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [end], Value = [fail], install = [96]
03-20 17:08:19.138+0900 E/ESD     (  905): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
03-20 17:08:19.138+0900 W/AUL_AMD (  629): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
03-20 17:08:19.138+0900 W/ISF_PANEL_EFL(  798): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.calculator",~) returned -1
03-20 17:08:19.148+0900 W/ISF_PANEL_EFL(  798): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
03-20 17:08:20.979+0900 E/PKGMGR_SERVER(10250): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10253]
03-20 17:08:21.060+0900 E/PKGMGR_SERVER(10250): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
03-20 17:08:21.060+0900 E/PKGMGR_SERVER(10250): pkgmgr-server.c: main(2471) > package manager server terminated.
03-20 17:08:23.312+0900 E/PKGMGR  (10303): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
03-20 17:08:23.392+0900 E/PKGMGR_SERVER(10305): pkgmgr-server.c: main(2414) > package manager server start
03-20 17:08:23.442+0900 E/PKGMGR_SERVER(10305): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.calculator-1.0.0-arm.tpk]
03-20 17:08:23.452+0900 E/PKGMGR_INFO(10305): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.calculator-1.0.0-arm.tpk] not found in DB
03-20 17:08:23.452+0900 E/rpm-installer(10305): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
03-20 17:08:23.462+0900 E/PKGMGR_SERVER(10305): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
03-20 17:08:23.462+0900 E/PKGMGR  (10303): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[103030002]
03-20 17:08:23.582+0900 E/PKGMGR_INSTALLER(10308): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
03-20 17:08:23.582+0900 E/rpm-installer(10308): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.calculator-1.0.0-arm.tpk] is tpk package.
03-20 17:08:23.592+0900 E/rpm-installer(10308): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
03-20 17:08:23.592+0900 E/rpm-installer(10308): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
03-20 17:08:23.592+0900 E/rpm-installer(10308): coretpk-parser.c: __coretpk_parser_get_value_list(1104) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
03-20 17:08:23.592+0900 E/rpm-installer(10308): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
03-20 17:08:23.592+0900 E/rpm-installer(10308): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
03-20 17:08:23.592+0900 E/rpm-installer(10308): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
03-20 17:08:23.692+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: start, val: install
03-20 17:08:23.692+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [start], Value = [install], install = [96]
03-20 17:08:23.702+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: install_percent, val: 30
03-20 17:08:23.702+0900 I/Tizen::App( 1243): (119) > InstallationInProgress [30]
03-20 17:08:23.702+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [install_percent], Value = [30], install = [96]
03-20 17:08:23.782+0900 E/rpm-installer(10308): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
03-20 17:08:23.782+0900 E/rpm-installer(10308): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
03-20 17:08:23.782+0900 E/rpm-installer(10308): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
03-20 17:08:23.782+0900 E/rpm-installer(10308): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
03-20 17:08:23.792+0900 E/rpm-installer(10308): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
03-20 17:08:23.792+0900 E/rpm-installer(10308): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
03-20 17:08:23.792+0900 E/PKGMGR_PARSER(10308): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
03-20 17:08:23.802+0900 E/PKGMGR_PARSER(10308): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
03-20 17:08:24.032+0900 E/PKGMGR_PARSER(10308): pkgmgr_parser.c: __check_theme(142) > theme for installation.
03-20 17:08:24.052+0900 E/PKGMGR_CERT(10308): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
03-20 17:08:24.052+0900 E/PKGMGR_CERT(10308): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 118
03-20 17:08:24.052+0900 E/PKGMGR_CERT(10308): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 118
03-20 17:08:24.052+0900 E/PKGMGR_CERT(10308): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 36 12
03-20 17:08:24.052+0900 E/PKGMGR_CERT(10308): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 37 12
03-20 17:08:24.052+0900 E/PKGMGR_CERT(10308): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 12
03-20 17:08:24.052+0900 E/PKGMGR_CERT(10308): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 12
03-20 17:08:24.062+0900 E/PKGMGR_CERT(10308): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
03-20 17:08:24.062+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: install_percent, val: 60
03-20 17:08:24.062+0900 I/Tizen::App( 1243): (119) > InstallationInProgress [60]
03-20 17:08:24.062+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [install_percent], Value = [60], install = [96]
03-20 17:08:24.083+0900 E/rpm-installer(10308): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
03-20 17:08:24.103+0900 E/rpm-installer(10308): coretpk-installer.c: __post_install_for_mmc(649) > (handle == NULL) handle is NULL.
03-20 17:08:24.103+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: install_percent, val: 100
03-20 17:08:24.103+0900 I/Tizen::App( 1243): (119) > InstallationInProgress [100]
03-20 17:08:24.103+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [install_percent], Value = [100], install = [96]
03-20 17:08:26.064+0900 E/PKGMGR_SERVER(10305): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
03-20 17:08:26.205+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: end, val: ok
03-20 17:08:26.205+0900 I/Tizen::App( 1243): (78) > Installation is Completed. [Package = org.example.calculator]
03-20 17:08:26.205+0900 I/Tizen::App( 1243): (671) > Enter. package(org.example.calculator), installationResult(0)
03-20 17:08:26.205+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
03-20 17:08:26.205+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
03-20 17:08:26.205+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
03-20 17:08:26.215+0900 I/Tizen::App( 1243): (1360) > package(org.example.calculator), version(1.0.0), type(tpk), displayName(calculator), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.calculator), storeClient(), appRootPath(/opt/usr/apps/org.example.calculator)
03-20 17:08:26.235+0900 I/Tizen::App( 1243): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.calculator]
03-20 17:08:26.245+0900 I/Tizen::App( 1243): (416) > appName = [calculator]
03-20 17:08:26.245+0900 I/Tizen::App( 1243): (509) > exe = [/opt/usr/apps/org.example.calculator/bin/calculator], displayName = [calculator], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
03-20 17:08:26.245+0900 E/PKGMGR_INFO( 1243): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
03-20 17:08:26.245+0900 I/Tizen::App( 1243): (683) > Application count(1) in this package
03-20 17:08:26.245+0900 I/Tizen::App( 1243): (703) > Exit.
03-20 17:08:26.245+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [end], Value = [ok], install = [96]
03-20 17:08:26.255+0900 I/Tizen::App( 1243): (840) > Enter.
03-20 17:08:26.265+0900 W/ISF_PANEL_EFL(  798): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
03-20 17:08:26.285+0900 E/PKGMGR_SERVER(10305): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10308]
03-20 17:08:26.295+0900 I/Tizen::App( 1243): (416) > appName = [calculator]
03-20 17:08:26.295+0900 I/Tizen::App( 1243): (509) > exe = [/opt/usr/apps/org.example.calculator/bin/calculator], displayName = [calculator], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
03-20 17:08:26.305+0900 I/Tizen::App( 1243): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.calculator.info]
03-20 17:08:26.305+0900 I/Tizen::App( 1243): (131) > Enter
03-20 17:08:26.305+0900 I/Tizen::App( 1243): (137) > org.example.calculator does not have launch condition
03-20 17:08:26.305+0900 I/Tizen::App( 1243): (883) > Exit.
03-20 17:08:26.315+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.calculator]
03-20 17:08:26.315+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.calculator]
03-20 17:08:26.315+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
03-20 17:08:26.315+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
03-20 17:08:26.315+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.calculator]
03-20 17:08:26.335+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[calculator] enable[1] system[0]
03-20 17:08:26.335+0900 E/HOME_APPS(  851): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.calculator] mdm is not enabled
03-20 17:08:26.335+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[calculator] enable[1] system[0]
03-20 17:08:26.335+0900 W/HOME_APPS(  851): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.calculator/shared/res/calculator.png], New icon path[/opt/usr/apps/org.example.calculator/shared/res/calculator.png]!!!!!
03-20 17:08:26.355+0900 E/util-view(  851): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
03-20 17:08:26.375+0900 W/HOME_APPS(  851): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.calculator/shared/res/calculator.png], Loading state:[1]
03-20 17:08:28.066+0900 E/PKGMGR_SERVER(10305): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
03-20 17:08:28.066+0900 E/PKGMGR_SERVER(10305): pkgmgr-server.c: main(2471) > package manager server terminated.
03-20 17:08:31.570+0900 W/AUL     (10364): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.calculator)
03-20 17:08:31.570+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 0
03-20 17:08:31.580+0900 I/AUL     (  629): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
03-20 17:08:31.590+0900 I/AUL     (  629): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
03-20 17:08:31.590+0900 E/AUL_AMD (  629): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
03-20 17:08:31.590+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(2508) > caller pid : 10364
03-20 17:08:31.590+0900 E/AUL_AMD (  629): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
03-20 17:08:31.590+0900 E/RESOURCED(  718): block.c: block_prelaunch_state(134) > insert data org.example.calculator, table num : 11
03-20 17:08:31.590+0900 E/RESOURCED(  718): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
03-20 17:08:31.600+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(3052) > pad pid(-5)
03-20 17:08:31.600+0900 W/AUL_PAD ( 1562): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
03-20 17:08:31.600+0900 W/AUL_PAD ( 1562): launchpad.c: __send_result_to_caller(267) > Check app launching
03-20 17:08:31.620+0900 I/CAPI_APPFW_APPLICATION(10047): app_main.c: ui_app_main(789) > app_efl_main
03-20 17:08:31.620+0900 I/CAPI_APPFW_APPLICATION(10047): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
03-20 17:08:31.650+0900 E/TBM     (10047): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
03-20 17:08:31.700+0900 W/AUL     (  629): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 10047, appid: org.example.calculator
03-20 17:08:31.700+0900 E/AUL     (  629): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
03-20 17:08:31.700+0900 E/RESOURCED(  718): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.calculator
03-20 17:08:31.710+0900 W/AUL     (10364): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10047)
03-20 17:08:31.940+0900 I/APP_CORE(10047): appcore-efl.c: __do_app(514) > [APP 10047] Event: RESET State: CREATED
03-20 17:08:31.940+0900 I/CAPI_APPFW_APPLICATION(10047): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
03-20 17:08:31.940+0900 E/EFL     (10047): edje<10047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:31.940+0900 E/EFL     (10047): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:31.940+0900 E/EFL     (10047): edje<10047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:31.940+0900 E/EFL     (10047): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:31.940+0900 E/EFL     (10047): edje<10047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:31.940+0900 E/EFL     (10047): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:31.940+0900 E/EFL     (10047): edje<10047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:31.940+0900 E/EFL     (10047): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:31.950+0900 E/EFL     (10047): edje<10047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:31.950+0900 E/EFL     (10047): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:31.970+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:08:31.970+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:08:31.990+0900 I/Tizen::System( 1243): (259) > Active app [org.exampl], current [com.samsun] 
03-20 17:08:31.990+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:08:32.000+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:08:32.000+0900 W/APP_CORE(10047): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
03-20 17:08:32.000+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 35
03-20 17:08:32.000+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:08:32.060+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: PAUSE State: RUNNING
03-20 17:08:32.060+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
03-20 17:08:32.060+0900 E/cluster-home(  851): homescreen.cpp: OnPause(260) >  app pause
03-20 17:08:32.060+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(4)
03-20 17:08:32.060+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(851)
03-20 17:08:32.060+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: bg
03-20 17:08:32.060+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(10047) status(3)
03-20 17:08:32.070+0900 W/AUL_AMD (  629): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-20 17:08:32.070+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
03-20 17:08:32.070+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.calculator(10047)
03-20 17:08:32.070+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10047, appid: org.example.calculator, status: fg
03-20 17:08:32.070+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
03-20 17:08:32.070+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
03-20 17:08:32.070+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: bg
03-20 17:08:32.070+0900 I/APP_CORE(10047): appcore-efl.c: __do_app(514) > [APP 10047] Event: RESUME State: CREATED
03-20 17:08:32.090+0900 I/APP_CORE(10047): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
03-20 17:08:32.090+0900 I/APP_CORE(10047): appcore-efl.c: __do_app(625) > [APP 10047] Initial Launching, call the resume_cb
03-20 17:08:32.090+0900 I/CAPI_APPFW_APPLICATION(10047): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:08:32.421+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(10047) status(0)
03-20 17:08:32.741+0900 E/RESOURCED(  718): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.896
03-20 17:08:32.751+0900 I/Tizen::App( 1243): (499) > LaunchedApp(org.example.calculator)
03-20 17:08:32.751+0900 I/Tizen::App( 1243): (733) > Finished invoking application event listener for org.example.calculator, 10047.
03-20 17:08:33.502+0900 I/UXT     (10373): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
03-20 17:08:33.912+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30871852
03-20 17:08:33.972+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30871906
03-20 17:08:33.972+0900 E/VCONF   (10047): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
03-20 17:08:33.972+0900 E/VCONF   (10047): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
03-20 17:08:33.972+0900 E/VCONF   (10047): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
03-20 17:08:33.972+0900 E/VCONF   (10047): vconf.c: vconf_get_bool(2729) > vconf_get_bool(10047) : db/ise/keysound error
03-20 17:08:33.972+0900 E/VCONF   (10047): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
03-20 17:08:33.972+0900 E/VCONF   (10047): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
03-20 17:08:34.122+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30872047
03-20 17:08:34.192+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30872134
03-20 17:08:34.353+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30872287
03-20 17:08:34.433+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30872373
03-20 17:08:34.723+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30872660
03-20 17:08:34.833+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30872770
03-20 17:08:35.183+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30873116
03-20 17:08:35.263+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30873202
03-20 17:08:35.384+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30873322
03-20 17:08:35.474+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30873408
03-20 17:08:35.604+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30873539
03-20 17:08:35.684+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30873626
03-20 17:08:35.994+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30873928
03-20 17:08:36.054+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30873993
03-20 17:08:36.405+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30874340
03-20 17:08:36.485+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30874426
03-20 17:08:36.615+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30874557
03-20 17:08:36.715+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30874654
03-20 17:08:36.835+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30874774
03-20 17:08:36.935+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30874871
03-20 17:08:37.075+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: MEM_FLUSH State: PAUSED
03-20 17:08:38.657+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30876591
03-20 17:08:38.787+0900 E/EFL     (10047): ecore_x<10047> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30876721
03-20 17:08:38.797+0900 E/EFL     (10047): <10047> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
03-20 17:08:38.917+0900 I/AUL_PAD ( 1562): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10047 pgid = 10047
03-20 17:08:38.917+0900 I/AUL_PAD ( 1562): sigchild.h: __sigchild_action(143) > dead_pid(10047)
03-20 17:08:38.927+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:08:38.967+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(3)
03-20 17:08:38.967+0900 W/AUL_AMD (  629): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-20 17:08:38.967+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
03-20 17:08:38.967+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(851)
03-20 17:08:38.967+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: fg
03-20 17:08:38.967+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
03-20 17:08:38.997+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: RESUME State: PAUSED
03-20 17:08:38.997+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:08:38.997+0900 E/cluster-home(  851): homescreen.cpp: OnResume(233) >  app resume
03-20 17:08:39.007+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:08:39.007+0900 I/AUL_PAD ( 1562): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
03-20 17:08:39.007+0900 I/AUL_PAD ( 1562): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
03-20 17:08:39.007+0900 E/AUL_PAD ( 1562): launchpad.c: main(698) > error reading sigchld info
03-20 17:08:39.007+0900 I/ESD     (  905): esd_main.c: __esd_app_dead_handler(1773) > pid: 10047
03-20 17:08:39.007+0900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10047
03-20 17:08:39.007+0900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10047
03-20 17:08:39.017+0900 E/RESOURCED(  718): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.900
03-20 17:08:39.037+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
03-20 17:08:39.037+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
03-20 17:08:39.037+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: fg
03-20 17:08:39.047+0900 I/Tizen::System( 1243): (259) > Active app [com.samsun], current [org.exampl] 
03-20 17:08:39.047+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:08:39.047+0900 E/RESOURCED(  718): datausage-common.c: app_terminated_cb(643) > No classid to terminate!
03-20 17:08:39.067+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:39.067+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:39.077+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=1, ret=0x0
03-20 17:08:39.077+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:08:39.087+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=1, ret=0x0
03-20 17:08:39.087+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:08:39.087+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:08:39.117+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:08:39.117+0900 I/Tizen::App( 1243): (243) > App[org.example.calculator] pid[10047] terminate event is forwarded
03-20 17:08:39.117+0900 I/Tizen::System( 1243): (256) > osp.accessorymanager.service provider is found.
03-20 17:08:39.117+0900 I/Tizen::System( 1243): (196) > Accessory Owner is removed [org.example.calculator, 10047, ]
03-20 17:08:39.117+0900 I/Tizen::System( 1243): (256) > osp.system.service provider is found.
03-20 17:08:39.117+0900 I/Tizen::App( 1243): (506) > TerminatedApp(org.example.calculator)
03-20 17:08:39.117+0900 I/Tizen::App( 1243): (512) > Not registered pid(10047)
03-20 17:08:39.117+0900 I/Tizen::System( 1243): (246) > Terminated app [org.example.calculator]
03-20 17:08:39.117+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:08:39.117+0900 W/CRASH_MANAGER(10379): worker.c: worker_job(1199) > 111004763616c1458461318
03-20 17:08:39.137+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:08:39.137+0900 I/Tizen::App( 1243): (782) > Finished invoking application event listener for org.example.calculator, 10047.
03-20 17:08:40.038+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.038+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.058+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.058+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.078+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.078+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.098+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.098+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.118+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.118+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.128+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.138+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.148+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.148+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.168+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.168+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.188+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.188+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.208+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.208+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.228+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.228+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.228+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.238+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:40.248+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:40.248+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:42.591+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30880530
03-20 17:08:42.641+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
03-20 17:08:42.641+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
03-20 17:08:42.651+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
03-20 17:08:42.651+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
03-20 17:08:42.651+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: bg
03-20 17:08:42.761+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30880703
03-20 17:08:43.892+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30881833
03-20 17:08:43.982+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30881919
03-20 17:08:43.982+0900 W/AUL     (  851): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.calculator)
03-20 17:08:43.982+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 1
03-20 17:08:43.982+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(2508) > caller pid : 851
03-20 17:08:43.992+0900 E/RESOURCED(  718): block.c: block_prelaunch_state(134) > insert data org.example.calculator, table num : 11
03-20 17:08:43.992+0900 E/RESOURCED(  718): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
03-20 17:08:43.992+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(3052) > pad pid(-5)
03-20 17:08:44.002+0900 W/AUL_PAD ( 1562): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
03-20 17:08:44.002+0900 W/AUL_PAD ( 1562): launchpad.c: __send_result_to_caller(267) > Check app launching
03-20 17:08:44.012+0900 I/CAPI_APPFW_APPLICATION(10373): app_main.c: ui_app_main(789) > app_efl_main
03-20 17:08:44.022+0900 I/CAPI_APPFW_APPLICATION(10373): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
03-20 17:08:44.052+0900 E/TBM     (10373): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
03-20 17:08:44.102+0900 W/AUL     (  629): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 10373, appid: org.example.calculator
03-20 17:08:44.102+0900 E/AUL     (  629): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
03-20 17:08:44.102+0900 E/RESOURCED(  718): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.calculator
03-20 17:08:44.112+0900 W/AUL     (  851): launch.c: app_request_to_launchpad(425) > request cmd(1) result(10373)
03-20 17:08:44.372+0900 I/APP_CORE(10373): appcore-efl.c: __do_app(514) > [APP 10373] Event: RESET State: CREATED
03-20 17:08:44.372+0900 I/CAPI_APPFW_APPLICATION(10373): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
03-20 17:08:44.372+0900 E/EFL     (10373): edje<10373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:44.372+0900 E/EFL     (10373): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:44.372+0900 E/EFL     (10373): edje<10373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:44.372+0900 E/EFL     (10373): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:44.372+0900 E/EFL     (10373): edje<10373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:44.372+0900 E/EFL     (10373): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:44.372+0900 E/EFL     (10373): edje<10373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:44.372+0900 E/EFL     (10373): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:44.382+0900 E/EFL     (10373): edje<10373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:08:44.382+0900 E/EFL     (10373): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:08:44.412+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:08:44.412+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:08:44.442+0900 I/Tizen::System( 1243): (259) > Active app [org.exampl], current [com.samsun] 
03-20 17:08:44.442+0900 W/APP_CORE(10373): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7200002
03-20 17:08:44.442+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:08:44.442+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 35
03-20 17:08:44.452+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:08:44.452+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:08:44.502+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: PAUSE State: RUNNING
03-20 17:08:44.502+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
03-20 17:08:44.502+0900 E/cluster-home(  851): homescreen.cpp: OnPause(260) >  app pause
03-20 17:08:44.502+0900 I/APP_CORE(10373): appcore-efl.c: __do_app(514) > [APP 10373] Event: RESUME State: CREATED
03-20 17:08:44.512+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(4)
03-20 17:08:44.512+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(851)
03-20 17:08:44.512+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: bg
03-20 17:08:44.522+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(10373) status(3)
03-20 17:08:44.522+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.calculator(10373)
03-20 17:08:44.522+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10373, appid: org.example.calculator, status: fg
03-20 17:08:44.522+0900 I/APP_CORE(10373): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
03-20 17:08:44.522+0900 I/APP_CORE(10373): appcore-efl.c: __do_app(625) > [APP 10373] Initial Launching, call the resume_cb
03-20 17:08:44.522+0900 I/CAPI_APPFW_APPLICATION(10373): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:08:44.863+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(10373) status(0)
03-20 17:08:45.133+0900 E/RESOURCED(  718): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.902
03-20 17:08:45.143+0900 I/Tizen::App( 1243): (499) > LaunchedApp(org.example.calculator)
03-20 17:08:45.143+0900 I/Tizen::App( 1243): (733) > Finished invoking application event listener for org.example.calculator, 10373.
03-20 17:08:45.303+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30883241
03-20 17:08:45.383+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30883327
03-20 17:08:45.393+0900 E/VCONF   (10373): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
03-20 17:08:45.393+0900 E/VCONF   (10373): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
03-20 17:08:45.393+0900 E/VCONF   (10373): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
03-20 17:08:45.393+0900 E/VCONF   (10373): vconf.c: vconf_get_bool(2729) > vconf_get_bool(10373) : db/ise/keysound error
03-20 17:08:45.393+0900 E/VCONF   (10373): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
03-20 17:08:45.393+0900 E/VCONF   (10373): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
03-20 17:08:45.513+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30883447
03-20 17:08:45.583+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30883522
03-20 17:08:45.714+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30883653
03-20 17:08:45.794+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30883729
03-20 17:08:45.974+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30883914
03-20 17:08:45.984+0900 I/UXT     (10409): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
03-20 17:08:46.064+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30884000
03-20 17:08:46.484+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30884421
03-20 17:08:46.594+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30884529
03-20 17:08:46.604+0900 E/EFL     (10373): <10373> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:08:47.205+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30885142
03-20 17:08:47.295+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30885228
03-20 17:08:47.305+0900 E/EFL     (10373): <10373> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:08:47.445+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30885381
03-20 17:08:47.515+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30885456
03-20 17:08:47.525+0900 E/EFL     (10373): <10373> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:08:47.645+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30885586
03-20 17:08:47.736+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30885673
03-20 17:08:47.746+0900 E/EFL     (10373): <10373> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:08:47.836+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30885771
03-20 17:08:47.936+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30885868
03-20 17:08:47.936+0900 E/EFL     (10373): <10373> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:08:47.966+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30885901
03-20 17:08:48.086+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30886020
03-20 17:08:48.096+0900 E/EFL     (10373): <10373> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:08:48.626+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30886558
03-20 17:08:48.747+0900 E/EFL     (10373): ecore_x<10373> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30886677
03-20 17:08:48.757+0900 E/EFL     (10373): <10373> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
03-20 17:08:48.867+0900 W/CRASH_MANAGER(10379): worker.c: worker_job(1199) > 111037363616c145846132
