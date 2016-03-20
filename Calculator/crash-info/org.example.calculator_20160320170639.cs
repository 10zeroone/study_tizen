S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDU0BOL4
Build-Date: 2015.12.24 17:18:01

Crash Information
Process Name: calculator
PID: 9961
Date: 2016-03-20 17:06:39+0900
Executable File Path: /opt/usr/apps/org.example.calculator/bin/calculator
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9961, uid 5000)

Register Information
r0   = 0xfffffff8, r1   = 0x00000000
r2   = 0x2ae59100, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb8b03130
r6   = 0xb8aeb4f8, r7   = 0xbee3c1f0
r8   = 0x800148a5, r9   = 0xb5e97708
r10  = 0xb8aeac30, fp   = 0xb5f70640
ip   = 0xffffffff, sp   = 0xbee3c1b8
lr   = 0xb27aba3d, pc   = 0xb66a90e4
cpsr = 0x600b0030

Memory Information
MemTotal:   987012 KB
MemFree:     84124 KB
Buffers:     51940 KB
Cached:     335024 KB
VmPeak:     125468 KB
VmSize:     125464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22660 KB
VmRSS:       22660 KB
VmData:      41488 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35696 KB
VmPTE:          90 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9961 TID = 9961
9961 9964 10045 10046 10051 

Maps Information
afa81000 b0280000 rw-p [stack:10051]
b12d0000 b1acf000 rw-p [stack:10046]
b1b12000 b1b23000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b33000 b1b38000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1b48000 b1b50000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b61000 b1b62000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b72000 b1b86000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b9a000 b1b9b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bab000 b1bae000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bbf000 b1bc0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bd0000 b1bd2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1be2000 b1be4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bf4000 b1c04000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c14000 b1c20000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c32000 b2431000 rw-p [stack:10045]
b2762000 b2769000 r-xp /usr/lib/libefl-extension.so.0.1.0
b277a000 b2782000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2794000 b279a000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27aa000 b27ac000 r-xp /opt/usr/apps/org.example.calculator/bin/calculator
b28fc000 b29df000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a16000 b2a3e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a50000 b324f000 rw-p [stack:9964]
b324f000 b3251000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3261000 b326b000 r-xp /lib/libnss_files-2.20-2014.11.so
b327c000 b3285000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3296000 b32a7000 r-xp /lib/libnsl-2.20-2014.11.so
b32ba000 b32c0000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32d1000 b32d2000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32fa000 b3301000 r-xp /usr/lib/libminizip.so.1.0.0
b3311000 b3316000 r-xp /usr/lib/libstorage.so.0.1
b3326000 b3385000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b339b000 b33af000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33bf000 b3403000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3413000 b341b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b342b000 b345b000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b346e000 b3527000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b353b000 b358e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b359f000 b35ba000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ca000 b368b000 r-xp /usr/lib/libprotobuf.so.9.0.1
b369e000 b36ae000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36be000 b36cb000 r-xp /usr/lib/libmdm-common.so.1.0.97
b36dc000 b36e3000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36f3000 b3734000 r-xp /usr/lib/libmdm.so.1.2.12
b3744000 b374c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b375b000 b376b000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b378c000 b37ec000 r-xp /usr/lib/libasound.so.2.0.0
b37fe000 b3801000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3811000 b3814000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3824000 b3829000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3839000 b383a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b384a000 b3854000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3868000 b386f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b387f000 b3885000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3895000 b389a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38aa000 b38c4000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38d5000 b38dc000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38ec000 b38ef000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3900000 b392e000 r-xp /usr/lib/libidn.so.11.5.44
b393e000 b3954000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3965000 b396f000 r-xp /usr/lib/libcares.so.2.1.0
b397f000 b3989000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b3999000 b399b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ab000 b39ac000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39bc000 b39c0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39d1000 b39f9000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a0a000 b3a33000 r-xp /usr/lib/libturbojpeg.so
b3a53000 b3a59000 r-xp /usr/lib/libgif.so.4.1.6
b3a69000 b3aaf000 r-xp /usr/lib/libcurl.so.4.3.0
b3ac0000 b3ae1000 r-xp /usr/lib/libexif.so.12.3.3
b3afc000 b3b11000 r-xp /usr/lib/libtts.so
b3b22000 b3b2a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b3a000 b3c00000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c20000 b3d18000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d37000 b3e05000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e1c000 b3e1e000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e2e000 b3e34000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e44000 b3e67000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e78000 b3e7a000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e8a000 b3e8c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e9d000 b3ea2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eb9000 b3ebb000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ecb000 b3ed2000 r-xp /usr/lib/libsensord-share.so
b3ee2000 b3efa000 r-xp /usr/lib/libsensor.so.1.1.0
b3f0b000 b3f0e000 r-xp /usr/lib/libXv.so.1.0.0
b3f1e000 b3f23000 r-xp /usr/lib/libutilX.so.1.1.0
b3f33000 b3f38000 r-xp /usr/lib/libappcore-common.so.1.1
b3f48000 b3f4f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f62000 b3f66000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f77000 b4055000 r-xp /usr/lib/libCOREGL.so.4.0
b4075000 b4078000 r-xp /usr/lib/libuuid.so.1.3.0
b4088000 b409f000 r-xp /usr/lib/libblkid.so.1.1.0
b40b0000 b40b2000 r-xp /usr/lib/libXau.so.6.0.0
b40c2000 b4109000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b411b000 b4121000 r-xp /usr/lib/libjson-c.so.2.0.1
b4132000 b4136000 r-xp /usr/lib/libogg.so.0.7.1
b4146000 b4168000 r-xp /usr/lib/libvorbis.so.0.4.3
b4178000 b425c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4278000 b427b000 r-xp /usr/lib/libEGL.so.1.4
b428c000 b4292000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42a2000 b42a4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42b4000 b42c1000 r-xp /usr/lib/libGLESv2.so.2.0
b42d2000 b4334000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4349000 b4361000 r-xp /usr/lib/libmount.so.1.1.0
b4373000 b4387000 r-xp /usr/lib/libxcb.so.1.1.0
b4397000 b439e000 r-xp /lib/libcrypt-2.20-2014.11.so
b43d6000 b43d8000 r-xp /usr/lib/libiri.so
b43e8000 b43f3000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4404000 b443a000 r-xp /usr/lib/libpulse.so.0.16.2
b444b000 b448e000 r-xp /usr/lib/libsndfile.so.1.0.25
b44a3000 b44b8000 r-xp /lib/libexpat.so.1.5.2
b44ca000 b4588000 r-xp /usr/lib/libcairo.so.2.11200.14
b459c000 b45a4000 r-xp /usr/lib/libdrm.so.2.4.0
b45b4000 b45b7000 r-xp /usr/lib/libdri2.so.0.0.0
b45c7000 b4615000 r-xp /usr/lib/libssl.so.1.0.0
b462a000 b4636000 r-xp /usr/lib/libeeze.so.1.13.0
b4647000 b4650000 r-xp /usr/lib/libethumb.so.1.13.0
b4660000 b4663000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4673000 b482a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5615000 b561e000 r-xp /usr/lib/libXi.so.6.1.0
b562e000 b5630000 r-xp /usr/lib/libXgesture.so.7.0.0
b5640000 b5644000 r-xp /usr/lib/libXtst.so.6.1.0
b5654000 b565a000 r-xp /usr/lib/libXrender.so.1.3.0
b566a000 b5670000 r-xp /usr/lib/libXrandr.so.2.2.0
b5680000 b5682000 r-xp /usr/lib/libXinerama.so.1.0.0
b5693000 b5696000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a6000 b56b1000 r-xp /usr/lib/libXext.so.6.4.0
b56c1000 b56c3000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d3000 b56d5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e5000 b57c7000 r-xp /usr/lib/libX11.so.6.3.0
b57db000 b57e2000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f2000 b580a000 r-xp /usr/lib/libudev.so.1.6.0
b580c000 b580f000 r-xp /lib/libattr.so.1.1.0
b581f000 b583f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5840000 b5845000 r-xp /usr/lib/libffi.so.6.0.2
b5856000 b586e000 r-xp /lib/libz.so.1.2.8
b587e000 b5880000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5890000 b5965000 r-xp /usr/lib/libxml2.so.2.9.2
b597a000 b5a15000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a31000 b5a34000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a44000 b5a5d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a6e000 b5a7f000 r-xp /lib/libresolv-2.20-2014.11.so
b5a93000 b5b0d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b22000 b5b24000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b34000 b5b3b000 r-xp /usr/lib/libembryo.so.1.13.0
b5b4b000 b5b55000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b66000 b5b7e000 r-xp /usr/lib/libpng12.so.0.50.0
b5b8f000 b5bb2000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bd3000 b5be7000 r-xp /usr/lib/libector.so.1.13.0
b5bf8000 b5c10000 r-xp /usr/lib/liblua-5.1.so
b5c21000 b5c78000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c8c000 b5cb4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cc5000 b5cd8000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ce9000 b5d23000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d34000 b5d42000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d52000 b5d5a000 r-xp /usr/lib/libtbm.so.1.0.0
b5d6a000 b5d77000 r-xp /usr/lib/libeio.so.1.13.0
b5d87000 b5d89000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d99000 b5d9e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dae000 b5dc5000 r-xp /usr/lib/libefreet.so.1.13.0
b5dd7000 b5df7000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e07000 b5e27000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e29000 b5e2f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e3f000 b5e50000 r-xp /usr/lib/libemotion.so.1.13.0
b5e61000 b5e68000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e78000 b5e87000 r-xp /usr/lib/libeo.so.1.13.0
b5e98000 b5eaa000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ebb000 b5ec0000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ed0000 b5ee9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ef9000 b5f16000 r-xp /usr/lib/libeet.so.1.13.0
b5f2f000 b5f77000 r-xp /usr/lib/libeina.so.1.13.0
b5f88000 b5f98000 r-xp /usr/lib/libefl.so.1.13.0
b5fa9000 b608e000 r-xp /usr/lib/libicuuc.so.51.1
b60ab000 b61eb000 r-xp /usr/lib/libicui18n.so.51.1
b6202000 b623a000 r-xp /usr/lib/libecore_x.so.1.13.0
b624c000 b624f000 r-xp /lib/libcap.so.2.21
b625f000 b6288000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6299000 b62a0000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62b2000 b62e9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62fa000 b63e5000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63f8000 b6471000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6483000 b6488000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6498000 b64a2000 r-xp /usr/lib/libvconf.so.0.2.45
b64b2000 b64b4000 r-xp /usr/lib/libvasum.so.0.3.1
b64c4000 b64c6000 r-xp /usr/lib/libttrace.so.1.1
b64d6000 b64d9000 r-xp /usr/lib/libiniparser.so.0
b64e9000 b650e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b651f000 b6524000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6535000 b654c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b655d000 b65c8000 r-xp /lib/libm-2.20-2014.11.so
b65d9000 b65df000 r-xp /lib/librt-2.20-2014.11.so
b65f0000 b65fd000 r-xp /usr/lib/libunwind.so.8.0.1
b6633000 b6757000 r-xp /lib/libc-2.20-2014.11.so
b676c000 b6785000 r-xp /lib/libgcc_s-4.9.so.1
b6795000 b6877000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6888000 b68b2000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68c3000 b68ff000 r-xp /usr/lib/libsystemd.so.0.4.0
b6901000 b6984000 r-xp /usr/lib/libedje.so.1.13.0
b6997000 b69b5000 r-xp /usr/lib/libecore.so.1.13.0
b69d5000 b6b5c000 r-xp /usr/lib/libevas.so.1.13.0
b6b91000 b6ba5000 r-xp /lib/libpthread-2.20-2014.11.so
b6bb9000 b6ded000 r-xp /usr/lib/libelementary.so.1.13.0
b6e1c000 b6e20000 r-xp /usr/lib/libsmack.so.1.0.0
b6e30000 b6e37000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e47000 b6e49000 r-xp /usr/lib/libdlog.so.0.0.0
b6e59000 b6e5c000 r-xp /usr/lib/libbundle.so.0.1.22
b6e6c000 b6e6e000 r-xp /lib/libdl-2.20-2014.11.so
b6e7f000 b6e97000 r-xp /usr/lib/libaul.so.0.1.0
b6eab000 b6eb0000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ec1000 b6ece000 r-xp /usr/lib/liblptcp.so
b6ee0000 b6ee4000 r-xp /usr/lib/libsys-assert.so
b6ef5000 b6f15000 r-xp /lib/ld-2.20-2014.11.so
b6f26000 b6f2b000 r-xp /usr/bin/launchpad-loader
b8898000 b8bd3000 rw-p [heap]
bee1c000 bee3d000 rw-p [stack]
b8898000 b8bd3000 rw-p [heap]
bee1c000 bee3d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9961)
Call Stack Count: 1
 0: strlen + 0x23 (0xb66a90e4) [/lib/libc.so.6] + 0x760e4
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
Dispatcher.cpp: OnEventReceived(158) > 2. Start next Sync job from main queue
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
03-20 17:06:26.087+0900 W/CRASH_MANAGER( 9941): worker.c: worker_job(1199) > 110990063616c1458461185
03-20 17:06:26.097+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:26.107+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(3)
03-20 17:06:26.107+0900 W/AUL_AMD (  629): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-20 17:06:26.107+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
03-20 17:06:26.107+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(851)
03-20 17:06:26.107+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: fg
03-20 17:06:26.117+0900 I/AUL_PAD ( 1562): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9900 pgid = 9900
03-20 17:06:26.117+0900 I/AUL_PAD ( 1562): sigchild.h: __sigchild_action(143) > dead_pid(9900)
03-20 17:06:26.167+0900 I/AUL_PAD ( 1562): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
03-20 17:06:26.167+0900 I/AUL_PAD ( 1562): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
03-20 17:06:26.167+0900 E/AUL_PAD ( 1562): launchpad.c: main(698) > error reading sigchld info
03-20 17:06:26.167+0900 I/Tizen::App( 1243): (243) > App[org.example.calculator] pid[9900] terminate event is forwarded
03-20 17:06:26.167+0900 I/Tizen::System( 1243): (256) > osp.accessorymanager.service provider is found.
03-20 17:06:26.167+0900 I/Tizen::System( 1243): (196) > Accessory Owner is removed [org.example.calculator, 9900, ]
03-20 17:06:26.167+0900 I/Tizen::System( 1243): (256) > osp.system.service provider is found.
03-20 17:06:26.167+0900 I/Tizen::App( 1243): (506) > TerminatedApp(org.example.calculator)
03-20 17:06:26.167+0900 I/Tizen::App( 1243): (512) > Not registered pid(9900)
03-20 17:06:26.167+0900 I/Tizen::System( 1243): (246) > Terminated app [org.example.calculator]
03-20 17:06:26.167+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:06:26.167+0900 I/ESD     (  905): esd_main.c: __esd_app_dead_handler(1773) > pid: 9900
03-20 17:06:26.167+0900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9900
03-20 17:06:26.167+0900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9900
03-20 17:06:26.167+0900 E/RESOURCED(  718): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.872
03-20 17:06:26.167+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
03-20 17:06:26.167+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:26.167+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: RESUME State: PAUSED
03-20 17:06:26.167+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:06:26.167+0900 E/cluster-home(  851): homescreen.cpp: OnResume(233) >  app resume
03-20 17:06:26.177+0900 E/RESOURCED(  718): datausage-common.c: app_terminated_cb(643) > No classid to terminate!
03-20 17:06:26.177+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:06:26.177+0900 I/Tizen::App( 1243): (782) > Finished invoking application event listener for org.example.calculator, 9900.
03-20 17:06:26.197+0900 I/Tizen::System( 1243): (259) > Active app [com.samsun], current [org.exampl] 
03-20 17:06:26.197+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:06:26.197+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
03-20 17:06:26.197+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
03-20 17:06:26.197+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: fg
03-20 17:06:26.208+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:06:26.218+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=1, ret=0x0
03-20 17:06:26.218+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:06:26.218+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=1, ret=0x0
03-20 17:06:26.218+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:06:26.218+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:06:26.228+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:26.238+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.218+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.229+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.239+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.239+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.259+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.259+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.279+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.279+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.299+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.299+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.319+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.319+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.329+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.339+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.349+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.349+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.369+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.369+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.389+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.389+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.409+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.409+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.419+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.429+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:27.439+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:27.439+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:34.025+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30751962
03-20 17:06:34.075+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30752016
03-20 17:06:34.085+0900 W/AUL     (  851): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.calculator)
03-20 17:06:34.085+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 1
03-20 17:06:34.085+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(2508) > caller pid : 851
03-20 17:06:34.095+0900 E/RESOURCED(  718): block.c: block_prelaunch_state(134) > insert data org.example.calculator, table num : 11
03-20 17:06:34.095+0900 E/RESOURCED(  718): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
03-20 17:06:34.095+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(3052) > pad pid(-5)
03-20 17:06:34.095+0900 W/AUL_PAD ( 1562): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
03-20 17:06:34.095+0900 W/AUL_PAD ( 1562): launchpad.c: __send_result_to_caller(267) > Check app launching
03-20 17:06:34.115+0900 I/CAPI_APPFW_APPLICATION( 9961): app_main.c: ui_app_main(789) > app_efl_main
03-20 17:06:34.115+0900 I/CAPI_APPFW_APPLICATION( 9961): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
03-20 17:06:34.145+0900 E/TBM     ( 9961): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
03-20 17:06:34.195+0900 W/AUL     (  629): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9961, appid: org.example.calculator
03-20 17:06:34.195+0900 E/AUL     (  629): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
03-20 17:06:34.195+0900 E/RESOURCED(  718): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.calculator
03-20 17:06:34.205+0900 W/AUL     (  851): launch.c: app_request_to_launchpad(425) > request cmd(1) result(9961)
03-20 17:06:34.416+0900 I/APP_CORE( 9961): appcore-efl.c: __do_app(514) > [APP 9961] Event: RESET State: CREATED
03-20 17:06:34.416+0900 I/CAPI_APPFW_APPLICATION( 9961): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
03-20 17:06:34.426+0900 E/EFL     ( 9961): edje<9961> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:34.426+0900 E/EFL     ( 9961): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:34.426+0900 E/EFL     ( 9961): edje<9961> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:34.426+0900 E/EFL     ( 9961): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:34.426+0900 E/EFL     ( 9961): edje<9961> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:34.426+0900 E/EFL     ( 9961): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:34.426+0900 E/EFL     ( 9961): edje<9961> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:34.426+0900 E/EFL     ( 9961): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:34.426+0900 E/EFL     ( 9961): edje<9961> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:34.426+0900 E/EFL     ( 9961): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:34.456+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:34.456+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:34.476+0900 I/Tizen::System( 1243): (259) > Active app [org.exampl], current [com.samsun] 
03-20 17:06:34.476+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:06:34.476+0900 W/APP_CORE( 9961): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
03-20 17:06:34.476+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:06:34.476+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 35
03-20 17:06:34.486+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:06:34.536+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: PAUSE State: RUNNING
03-20 17:06:34.536+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
03-20 17:06:34.536+0900 E/cluster-home(  851): homescreen.cpp: OnPause(260) >  app pause
03-20 17:06:34.536+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(4)
03-20 17:06:34.536+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(851)
03-20 17:06:34.536+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: bg
03-20 17:06:34.546+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(9961) status(3)
03-20 17:06:34.546+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.calculator(9961)
03-20 17:06:34.546+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9961, appid: org.example.calculator, status: fg
03-20 17:06:34.546+0900 I/APP_CORE( 9961): appcore-efl.c: __do_app(514) > [APP 9961] Event: RESUME State: CREATED
03-20 17:06:34.556+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
03-20 17:06:34.556+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
03-20 17:06:34.556+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: bg
03-20 17:06:34.566+0900 I/APP_CORE( 9961): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
03-20 17:06:34.566+0900 I/APP_CORE( 9961): appcore-efl.c: __do_app(625) > [APP 9961] Initial Launching, call the resume_cb
03-20 17:06:34.566+0900 I/CAPI_APPFW_APPLICATION( 9961): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:06:34.896+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(9961) status(0)
03-20 17:06:35.246+0900 I/Tizen::App( 1243): (499) > LaunchedApp(org.example.calculator)
03-20 17:06:35.246+0900 E/RESOURCED(  718): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.873
03-20 17:06:35.266+0900 I/Tizen::App( 1243): (733) > Finished invoking application event listener for org.example.calculator, 9961.
03-20 17:06:35.997+0900 I/UXT     (10047): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
03-20 17:06:36.648+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30754590
03-20 17:06:36.708+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30754645
03-20 17:06:36.708+0900 E/VCONF   ( 9961): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
03-20 17:06:36.708+0900 E/VCONF   ( 9961): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
03-20 17:06:36.708+0900 E/VCONF   ( 9961): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
03-20 17:06:36.708+0900 E/VCONF   ( 9961): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9961) : db/ise/keysound error
03-20 17:06:36.708+0900 E/VCONF   ( 9961): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
03-20 17:06:36.708+0900 E/VCONF   ( 9961): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
03-20 17:06:36.838+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30754775
03-20 17:06:36.918+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30754861
03-20 17:06:37.038+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30754981
03-20 17:06:37.118+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30755067
03-20 17:06:37.368+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30755306
03-20 17:06:37.448+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30755382
03-20 17:06:37.448+0900 E/EFL     ( 9961): <9961> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:06:38.059+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30756006
03-20 17:06:38.139+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30756081
03-20 17:06:38.149+0900 E/EFL     ( 9961): <9961> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:06:38.329+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30756265
03-20 17:06:38.379+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30756319
03-20 17:06:38.389+0900 E/EFL     ( 9961): <9961> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:06:38.459+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30756406
03-20 17:06:38.550+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30756493
03-20 17:06:38.550+0900 E/EFL     ( 9961): <9961> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:06:39.090+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30757027
03-20 17:06:39.150+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30757092
03-20 17:06:39.150+0900 E/EFL     ( 9961): <9961> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:06:39.280+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30757223
03-20 17:06:39.330+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30757276
03-20 17:06:39.340+0900 E/EFL     ( 9961): <9961> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:06:39.460+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30757396
03-20 17:06:39.531+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30757473
03-20 17:06:39.541+0900 E/EFL     ( 9961): <9961> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:06:39.541+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: MEM_FLUSH State: PAUSED
03-20 17:06:39.791+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=30757730
03-20 17:06:39.851+0900 E/EFL     ( 9961): ecore_x<9961> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=30757784
03-20 17:06:39.861+0900 E/EFL     ( 9961): <9961> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
03-20 17:06:39.971+0900 W/CRASH_MANAGER( 9941): worker.c: worker_job(1199) > 110996163616c145846119
