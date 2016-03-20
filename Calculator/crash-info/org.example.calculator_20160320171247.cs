S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDU0BOL4
Build-Date: 2015.12.24 17:18:01

Crash Information
Process Name: calculator
PID: 10409
Date: 2016-03-20 17:12:47+0900
Executable File Path: /opt/usr/apps/org.example.calculator/bin/calculator
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10409, uid 5000)

Register Information
r0   = 0xfffffff8, r1   = 0x00000000
r2   = 0xfb6a6600, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb7d87910
r6   = 0xb7d827d0, r7   = 0xbe90a1f0
r8   = 0x800148a5, r9   = 0xb5eda708
r10  = 0xb7d749b0, fp   = 0xb5fb3640
ip   = 0xffffffff, sp   = 0xbe90a1b8
lr   = 0xb27eea3d, pc   = 0xb66ec0e4
cpsr = 0x600b0030

Memory Information
MemTotal:   987012 KB
MemFree:     74252 KB
Buffers:     52968 KB
Cached:     335776 KB
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
PID = 10409 TID = 10409
10409 10413 10740 10741 10745 

Maps Information
afa81000 b0280000 rw-p [stack:10745]
b1313000 b1b12000 rw-p [stack:10741]
b1b55000 b1b66000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b76000 b1b7b000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1b8b000 b1b93000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1ba4000 b1ba5000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bb5000 b1bc9000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bdd000 b1bde000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bee000 b1bf1000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c02000 b1c03000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c13000 b1c15000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c25000 b1c27000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c37000 b1c47000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c57000 b1c63000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c75000 b2474000 rw-p [stack:10740]
b27a5000 b27ac000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27bd000 b27c5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27d7000 b27dd000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27ed000 b27ef000 r-xp /opt/usr/apps/org.example.calculator/bin/calculator
b293f000 b2a22000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a59000 b2a81000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a93000 b3292000 rw-p [stack:10413]
b3292000 b3294000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32a4000 b32ae000 r-xp /lib/libnss_files-2.20-2014.11.so
b32bf000 b32c8000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32d9000 b32ea000 r-xp /lib/libnsl-2.20-2014.11.so
b32fd000 b3303000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3314000 b3315000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b333d000 b3344000 r-xp /usr/lib/libminizip.so.1.0.0
b3354000 b3359000 r-xp /usr/lib/libstorage.so.0.1
b3369000 b33c8000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33de000 b33f2000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3402000 b3446000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3456000 b345e000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b346e000 b349e000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34b1000 b356a000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b357e000 b35d1000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35e2000 b35fd000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b360d000 b36ce000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36e1000 b36f1000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3701000 b370e000 r-xp /usr/lib/libmdm-common.so.1.0.97
b371f000 b3726000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3736000 b3777000 r-xp /usr/lib/libmdm.so.1.2.12
b3787000 b378f000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b379e000 b37ae000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37cf000 b382f000 r-xp /usr/lib/libasound.so.2.0.0
b3841000 b3844000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3854000 b3857000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3867000 b386c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b387c000 b387d000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b388d000 b3897000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38ab000 b38b2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38c2000 b38c8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38d8000 b38dd000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38ed000 b3907000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3918000 b391f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b392f000 b3932000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3943000 b3971000 r-xp /usr/lib/libidn.so.11.5.44
b3981000 b3997000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39a8000 b39b2000 r-xp /usr/lib/libcares.so.2.1.0
b39c2000 b39cc000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b39dc000 b39de000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ee000 b39ef000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39ff000 b3a03000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a14000 b3a3c000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a4d000 b3a76000 r-xp /usr/lib/libturbojpeg.so
b3a96000 b3a9c000 r-xp /usr/lib/libgif.so.4.1.6
b3aac000 b3af2000 r-xp /usr/lib/libcurl.so.4.3.0
b3b03000 b3b24000 r-xp /usr/lib/libexif.so.12.3.3
b3b3f000 b3b54000 r-xp /usr/lib/libtts.so
b3b65000 b3b6d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b7d000 b3c43000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c63000 b3d5b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d7a000 b3e48000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e5f000 b3e61000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e71000 b3e77000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e87000 b3eaa000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ebb000 b3ebd000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ecd000 b3ecf000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ee0000 b3ee5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3efc000 b3efe000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f0e000 b3f15000 r-xp /usr/lib/libsensord-share.so
b3f25000 b3f3d000 r-xp /usr/lib/libsensor.so.1.1.0
b3f4e000 b3f51000 r-xp /usr/lib/libXv.so.1.0.0
b3f61000 b3f66000 r-xp /usr/lib/libutilX.so.1.1.0
b3f76000 b3f7b000 r-xp /usr/lib/libappcore-common.so.1.1
b3f8b000 b3f92000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fa5000 b3fa9000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fba000 b4098000 r-xp /usr/lib/libCOREGL.so.4.0
b40b8000 b40bb000 r-xp /usr/lib/libuuid.so.1.3.0
b40cb000 b40e2000 r-xp /usr/lib/libblkid.so.1.1.0
b40f3000 b40f5000 r-xp /usr/lib/libXau.so.6.0.0
b4105000 b414c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b415e000 b4164000 r-xp /usr/lib/libjson-c.so.2.0.1
b4175000 b4179000 r-xp /usr/lib/libogg.so.0.7.1
b4189000 b41ab000 r-xp /usr/lib/libvorbis.so.0.4.3
b41bb000 b429f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42bb000 b42be000 r-xp /usr/lib/libEGL.so.1.4
b42cf000 b42d5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42e5000 b42e7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42f7000 b4304000 r-xp /usr/lib/libGLESv2.so.2.0
b4315000 b4377000 r-xp /usr/lib/libpixman-1.so.0.28.2
b438c000 b43a4000 r-xp /usr/lib/libmount.so.1.1.0
b43b6000 b43ca000 r-xp /usr/lib/libxcb.so.1.1.0
b43da000 b43e1000 r-xp /lib/libcrypt-2.20-2014.11.so
b4419000 b441b000 r-xp /usr/lib/libiri.so
b442b000 b4436000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4447000 b447d000 r-xp /usr/lib/libpulse.so.0.16.2
b448e000 b44d1000 r-xp /usr/lib/libsndfile.so.1.0.25
b44e6000 b44fb000 r-xp /lib/libexpat.so.1.5.2
b450d000 b45cb000 r-xp /usr/lib/libcairo.so.2.11200.14
b45df000 b45e7000 r-xp /usr/lib/libdrm.so.2.4.0
b45f7000 b45fa000 r-xp /usr/lib/libdri2.so.0.0.0
b460a000 b4658000 r-xp /usr/lib/libssl.so.1.0.0
b466d000 b4679000 r-xp /usr/lib/libeeze.so.1.13.0
b468a000 b4693000 r-xp /usr/lib/libethumb.so.1.13.0
b46a3000 b46a6000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46b6000 b486d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5658000 b5661000 r-xp /usr/lib/libXi.so.6.1.0
b5671000 b5673000 r-xp /usr/lib/libXgesture.so.7.0.0
b5683000 b5687000 r-xp /usr/lib/libXtst.so.6.1.0
b5697000 b569d000 r-xp /usr/lib/libXrender.so.1.3.0
b56ad000 b56b3000 r-xp /usr/lib/libXrandr.so.2.2.0
b56c3000 b56c5000 r-xp /usr/lib/libXinerama.so.1.0.0
b56d6000 b56d9000 r-xp /usr/lib/libXfixes.so.3.1.0
b56e9000 b56f4000 r-xp /usr/lib/libXext.so.6.4.0
b5704000 b5706000 r-xp /usr/lib/libXdamage.so.1.1.0
b5716000 b5718000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5728000 b580a000 r-xp /usr/lib/libX11.so.6.3.0
b581e000 b5825000 r-xp /usr/lib/libXcursor.so.1.0.2
b5835000 b584d000 r-xp /usr/lib/libudev.so.1.6.0
b584f000 b5852000 r-xp /lib/libattr.so.1.1.0
b5862000 b5882000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5883000 b5888000 r-xp /usr/lib/libffi.so.6.0.2
b5899000 b58b1000 r-xp /lib/libz.so.1.2.8
b58c1000 b58c3000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58d3000 b59a8000 r-xp /usr/lib/libxml2.so.2.9.2
b59bd000 b5a58000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a74000 b5a77000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a87000 b5aa0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ab1000 b5ac2000 r-xp /lib/libresolv-2.20-2014.11.so
b5ad6000 b5b50000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b65000 b5b67000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b77000 b5b7e000 r-xp /usr/lib/libembryo.so.1.13.0
b5b8e000 b5b98000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5ba9000 b5bc1000 r-xp /usr/lib/libpng12.so.0.50.0
b5bd2000 b5bf5000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c16000 b5c2a000 r-xp /usr/lib/libector.so.1.13.0
b5c3b000 b5c53000 r-xp /usr/lib/liblua-5.1.so
b5c64000 b5cbb000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ccf000 b5cf7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d08000 b5d1b000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d2c000 b5d66000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d77000 b5d85000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d95000 b5d9d000 r-xp /usr/lib/libtbm.so.1.0.0
b5dad000 b5dba000 r-xp /usr/lib/libeio.so.1.13.0
b5dca000 b5dcc000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5ddc000 b5de1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5df1000 b5e08000 r-xp /usr/lib/libefreet.so.1.13.0
b5e1a000 b5e3a000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e4a000 b5e6a000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e6c000 b5e72000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e82000 b5e93000 r-xp /usr/lib/libemotion.so.1.13.0
b5ea4000 b5eab000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ebb000 b5eca000 r-xp /usr/lib/libeo.so.1.13.0
b5edb000 b5eed000 r-xp /usr/lib/libecore_input.so.1.13.0
b5efe000 b5f03000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f13000 b5f2c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f3c000 b5f59000 r-xp /usr/lib/libeet.so.1.13.0
b5f72000 b5fba000 r-xp /usr/lib/libeina.so.1.13.0
b5fcb000 b5fdb000 r-xp /usr/lib/libefl.so.1.13.0
b5fec000 b60d1000 r-xp /usr/lib/libicuuc.so.51.1
b60ee000 b622e000 r-xp /usr/lib/libicui18n.so.51.1
b6245000 b627d000 r-xp /usr/lib/libecore_x.so.1.13.0
b628f000 b6292000 r-xp /lib/libcap.so.2.21
b62a2000 b62cb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62dc000 b62e3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62f5000 b632c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b633d000 b6428000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b643b000 b64b4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64c6000 b64cb000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64db000 b64e5000 r-xp /usr/lib/libvconf.so.0.2.45
b64f5000 b64f7000 r-xp /usr/lib/libvasum.so.0.3.1
b6507000 b6509000 r-xp /usr/lib/libttrace.so.1.1
b6519000 b651c000 r-xp /usr/lib/libiniparser.so.0
b652c000 b6551000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6562000 b6567000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6578000 b658f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65a0000 b660b000 r-xp /lib/libm-2.20-2014.11.so
b661c000 b6622000 r-xp /lib/librt-2.20-2014.11.so
b6633000 b6640000 r-xp /usr/lib/libunwind.so.8.0.1
b6676000 b679a000 r-xp /lib/libc-2.20-2014.11.so
b67af000 b67c8000 r-xp /lib/libgcc_s-4.9.so.1
b67d8000 b68ba000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68cb000 b68f5000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6906000 b6942000 r-xp /usr/lib/libsystemd.so.0.4.0
b6944000 b69c7000 r-xp /usr/lib/libedje.so.1.13.0
b69da000 b69f8000 r-xp /usr/lib/libecore.so.1.13.0
b6a18000 b6b9f000 r-xp /usr/lib/libevas.so.1.13.0
b6bd4000 b6be8000 r-xp /lib/libpthread-2.20-2014.11.so
b6bfc000 b6e30000 r-xp /usr/lib/libelementary.so.1.13.0
b6e5f000 b6e63000 r-xp /usr/lib/libsmack.so.1.0.0
b6e73000 b6e7a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e8a000 b6e8c000 r-xp /usr/lib/libdlog.so.0.0.0
b6e9c000 b6e9f000 r-xp /usr/lib/libbundle.so.0.1.22
b6eaf000 b6eb1000 r-xp /lib/libdl-2.20-2014.11.so
b6ec2000 b6eda000 r-xp /usr/lib/libaul.so.0.1.0
b6eee000 b6ef3000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f04000 b6f11000 r-xp /usr/lib/liblptcp.so
b6f23000 b6f27000 r-xp /usr/lib/libsys-assert.so
b6f38000 b6f58000 r-xp /lib/ld-2.20-2014.11.so
b6f69000 b6f6e000 r-xp /usr/bin/launchpad-loader
b7b22000 b7e5d000 rw-p [heap]
be8ea000 be90b000 rw-p [stack]
b7b22000 b7e5d000 rw-p [heap]
be8ea000 be90b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10409)
Call Stack Count: 1
 0: strlen + 0x23 (0xb66ec0e4) [/lib/libc.so.6] + 0x760e4
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
900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10373
03-20 17:08:49.017+0900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10373
03-20 17:08:49.017+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:49.017+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:49.027+0900 E/RESOURCED(  718): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.906
03-20 17:08:49.047+0900 E/RESOURCED(  718): datausage-common.c: app_terminated_cb(643) > No classid to terminate!
03-20 17:08:49.067+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=1, ret=0x0
03-20 17:08:49.067+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:08:49.077+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=1, ret=0x0
03-20 17:08:49.077+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:08:49.077+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:08:49.087+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:08:49.087+0900 I/Tizen::App( 1243): (243) > App[org.example.calculator] pid[10373] terminate event is forwarded
03-20 17:08:49.087+0900 I/Tizen::System( 1243): (256) > osp.accessorymanager.service provider is found.
03-20 17:08:49.087+0900 I/Tizen::System( 1243): (196) > Accessory Owner is removed [org.example.calculator, 10373, ]
03-20 17:08:49.087+0900 I/Tizen::System( 1243): (256) > osp.system.service provider is found.
03-20 17:08:49.087+0900 I/Tizen::App( 1243): (506) > TerminatedApp(org.example.calculator)
03-20 17:08:49.087+0900 I/Tizen::App( 1243): (512) > Not registered pid(10373)
03-20 17:08:49.087+0900 I/Tizen::System( 1243): (246) > Terminated app [org.example.calculator]
03-20 17:08:49.097+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:08:49.107+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:08:49.107+0900 I/Tizen::App( 1243): (782) > Finished invoking application event listener for org.example.calculator, 10373.
03-20 17:08:50.008+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.008+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.028+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.028+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.038+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.048+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.058+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.058+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.078+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.078+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.098+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.098+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.118+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.118+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.128+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.138+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.148+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.158+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.168+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.168+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.188+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.188+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:08:50.208+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:08:50.208+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:09:00.999+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(195) > ""
03-20 17:09:00.999+0900 E/UXT     (  714): uxt_date_time.c: uxt_date_time_get_format_by_locale(244) > format : %Y/%m/%d%p%l:%M
03-20 17:09:00.999+0900 E/UXT     (  714): uxt_util.c: uxt_util_get_date_time_text_by_locale(390) > text : 오후 5:09
03-20 17:09:00.999+0900 I/INDICATOR(  714): clock.c: getTimeFormatted(176) > "time format : 오후 5:09"
03-20 17:09:00.999+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 5:09"
03-20 17:09:00.999+0900 W/INDICATOR(  714): clock.c: indicator_clock_changed_cb(272) > 
03-20 17:09:00.999+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147474629 Time: <font_size=31> </font_size> <font_size=31> 오후 5:09</font_size></font>"
03-20 17:10:00.016+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(195) > ""
03-20 17:10:00.016+0900 E/UXT     (  714): uxt_date_time.c: uxt_date_time_get_format_by_locale(244) > format : %Y/%m/%d%p%l:%M
03-20 17:10:00.026+0900 E/UXT     (  714): uxt_util.c: uxt_util_get_date_time_text_by_locale(390) > text : 오후 5:10
03-20 17:10:00.026+0900 I/INDICATOR(  714): clock.c: getTimeFormatted(176) > "time format : 오후 5:10"
03-20 17:10:00.026+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 5:10"
03-20 17:10:00.026+0900 W/INDICATOR(  714): clock.c: indicator_clock_changed_cb(272) > 
03-20 17:10:00.026+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147472577 Time: <font_size=31> </font_size> <font_size=31> 오후 5:10</font_size></font>"
03-20 17:10:08.254+0900 I/Tizen::Net::Wifi( 1243): (941) > The background scan result updated.
03-20 17:11:00.065+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(195) > ""
03-20 17:11:00.065+0900 E/UXT     (  714): uxt_date_time.c: uxt_date_time_get_format_by_locale(244) > format : %Y/%m/%d%p%l:%M
03-20 17:11:00.075+0900 E/UXT     (  714): uxt_util.c: uxt_util_get_date_time_text_by_locale(390) > text : 오후 5:11
03-20 17:11:00.075+0900 I/INDICATOR(  714): clock.c: getTimeFormatted(176) > "time format : 오후 5:11"
03-20 17:11:00.075+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 5:11"
03-20 17:11:00.075+0900 W/INDICATOR(  714): clock.c: indicator_clock_changed_cb(272) > 
03-20 17:11:00.075+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147468989 Time: <font_size=31> </font_size> <font_size=31> 오후 5:11</font_size></font>"
03-20 17:12:00.123+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(195) > ""
03-20 17:12:00.123+0900 E/UXT     (  714): uxt_date_time.c: uxt_date_time_get_format_by_locale(244) > format : %Y/%m/%d%p%l:%M
03-20 17:12:00.123+0900 E/UXT     (  714): uxt_util.c: uxt_util_get_date_time_text_by_locale(390) > text : 오후 5:12
03-20 17:12:00.123+0900 I/INDICATOR(  714): clock.c: getTimeFormatted(176) > "time format : 오후 5:12"
03-20 17:12:00.123+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 5:12"
03-20 17:12:00.123+0900 W/INDICATOR(  714): clock.c: indicator_clock_changed_cb(272) > 
03-20 17:12:00.123+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147466937 Time: <font_size=31> </font_size> <font_size=31> 오후 5:12</font_size></font>"
03-20 17:12:15.879+0900 E/PKGMGR_SERVER(10527): pkgmgr-server.c: main(2414) > package manager server start
03-20 17:12:15.939+0900 E/PKGMGR  (10525): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.calculator, -1]
03-20 17:12:15.969+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 14
03-20 17:12:15.979+0900 W/AUL_AMD (  629): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
03-20 17:12:15.989+0900 E/PKGMGR_SERVER(10527): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10530]
03-20 17:12:18.061+0900 E/PKGMGR_SERVER(10527): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
03-20 17:12:18.061+0900 E/PKGMGR_SERVER(10527): pkgmgr-server.c: main(2471) > package manager server terminated.
03-20 17:12:18.201+0900 I/Tizen::Net::Wifi( 1243): (941) > The background scan result updated.
03-20 17:12:22.535+0900 E/PKGMGR  (10617): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
03-20 17:12:22.605+0900 E/PKGMGR_SERVER(10619): pkgmgr-server.c: main(2414) > package manager server start
03-20 17:12:22.655+0900 E/PKGMGR_SERVER(10619): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.calculator]
03-20 17:12:22.665+0900 E/PKGMGR_SERVER(10619): pm-mdm.c: _get_package_info_from_file(115) > [0;31m[_get_package_info_from_file(): 115](ret < 0) access() failed. path: org.example.calculator errno: 2 (No such file or directory)[0;m
03-20 17:12:22.665+0900 E/PKGMGR  (10617): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[106170002]
03-20 17:12:22.815+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: start, val: update
03-20 17:12:22.815+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [start], Value = [update], install = [96]
03-20 17:12:22.825+0900 W/AUL_AMD (  629): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
03-20 17:12:22.835+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: install_percent, val: 30
03-20 17:12:22.835+0900 I/Tizen::App( 1243): (119) > InstallationInProgress [30]
03-20 17:12:22.835+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [install_percent], Value = [30], install = [96]
03-20 17:12:22.966+0900 E/rpm-installer(10622): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
03-20 17:12:22.966+0900 E/rpm-installer(10622): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1569) > (pkg_file_info == NULL) pkg_file_info is NULL.
03-20 17:12:23.016+0900 E/PKGMGR_PARSER(10622): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
03-20 17:12:23.036+0900 E/PKGMGR_CERT(10622): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
03-20 17:12:23.036+0900 E/PKGMGR_CERT(10622): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
03-20 17:12:23.046+0900 E/PKGMGR_CERT(10622): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
03-20 17:12:23.076+0900 E/rpm-installer(10622): coretpk-installer.c: _coretpk_installer_package_reinstall(6322) > _coretpk_installer_package_reinstall(org.example.calculator) failed.
03-20 17:12:23.076+0900 E/ESD     (  905): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
03-20 17:12:23.086+0900 W/AUL_AMD (  629): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
03-20 17:12:23.086+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: end, val: fail
03-20 17:12:23.086+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [end], Value = [fail], install = [96]
03-20 17:12:23.086+0900 W/ISF_PANEL_EFL(  798): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.calculator",~) returned -1
03-20 17:12:23.096+0900 W/ISF_PANEL_EFL(  798): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
03-20 17:12:24.917+0900 E/PKGMGR_SERVER(10619): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10622]
03-20 17:12:25.058+0900 E/PKGMGR_SERVER(10619): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
03-20 17:12:25.058+0900 E/PKGMGR_SERVER(10619): pkgmgr-server.c: main(2471) > package manager server terminated.
03-20 17:12:27.380+0900 E/PKGMGR  (10673): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
03-20 17:12:27.470+0900 E/PKGMGR_SERVER(10675): pkgmgr-server.c: main(2414) > package manager server start
03-20 17:12:27.510+0900 E/PKGMGR_SERVER(10675): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.calculator-1.0.0-arm.tpk]
03-20 17:12:27.520+0900 E/PKGMGR_INFO(10675): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.calculator-1.0.0-arm.tpk] not found in DB
03-20 17:12:27.530+0900 E/rpm-installer(10675): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
03-20 17:12:27.540+0900 E/PKGMGR_SERVER(10675): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
03-20 17:12:27.540+0900 E/PKGMGR  (10673): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[106730002]
03-20 17:12:27.660+0900 E/PKGMGR_INSTALLER(10678): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
03-20 17:12:27.660+0900 E/rpm-installer(10678): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.calculator-1.0.0-arm.tpk] is tpk package.
03-20 17:12:27.670+0900 E/rpm-installer(10678): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
03-20 17:12:27.670+0900 E/rpm-installer(10678): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
03-20 17:12:27.670+0900 E/rpm-installer(10678): coretpk-parser.c: __coretpk_parser_get_value_list(1104) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
03-20 17:12:27.670+0900 E/rpm-installer(10678): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
03-20 17:12:27.680+0900 E/rpm-installer(10678): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
03-20 17:12:27.680+0900 E/rpm-installer(10678): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
03-20 17:12:27.780+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: start, val: install
03-20 17:12:27.780+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [start], Value = [install], install = [96]
03-20 17:12:27.790+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: install_percent, val: 30
03-20 17:12:27.790+0900 I/Tizen::App( 1243): (119) > InstallationInProgress [30]
03-20 17:12:27.790+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [install_percent], Value = [30], install = [96]
03-20 17:12:27.880+0900 E/rpm-installer(10678): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
03-20 17:12:27.880+0900 E/rpm-installer(10678): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
03-20 17:12:27.880+0900 E/rpm-installer(10678): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
03-20 17:12:27.880+0900 E/rpm-installer(10678): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
03-20 17:12:27.880+0900 E/rpm-installer(10678): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
03-20 17:12:27.880+0900 E/rpm-installer(10678): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
03-20 17:12:27.880+0900 E/PKGMGR_PARSER(10678): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
03-20 17:12:27.890+0900 E/PKGMGR_PARSER(10678): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
03-20 17:12:28.121+0900 E/PKGMGR_PARSER(10678): pkgmgr_parser.c: __check_theme(142) > theme for installation.
03-20 17:12:28.141+0900 E/PKGMGR_CERT(10678): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
03-20 17:12:28.141+0900 E/PKGMGR_CERT(10678): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 118
03-20 17:12:28.141+0900 E/PKGMGR_CERT(10678): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 118
03-20 17:12:28.141+0900 E/PKGMGR_CERT(10678): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 36 12
03-20 17:12:28.141+0900 E/PKGMGR_CERT(10678): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 37 12
03-20 17:12:28.141+0900 E/PKGMGR_CERT(10678): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 12
03-20 17:12:28.141+0900 E/PKGMGR_CERT(10678): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 12
03-20 17:12:28.151+0900 E/PKGMGR_CERT(10678): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
03-20 17:12:28.151+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: install_percent, val: 60
03-20 17:12:28.151+0900 I/Tizen::App( 1243): (119) > InstallationInProgress [60]
03-20 17:12:28.151+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [install_percent], Value = [60], install = [96]
03-20 17:12:28.171+0900 E/rpm-installer(10678): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
03-20 17:12:28.191+0900 E/rpm-installer(10678): coretpk-installer.c: __post_install_for_mmc(649) > (handle == NULL) handle is NULL.
03-20 17:12:28.191+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: install_percent, val: 100
03-20 17:12:28.191+0900 I/Tizen::App( 1243): (119) > InstallationInProgress [100]
03-20 17:12:28.191+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [install_percent], Value = [100], install = [96]
03-20 17:12:30.062+0900 E/PKGMGR_SERVER(10675): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
03-20 17:12:30.283+0900 I/Tizen::App( 1243): (1894) > PackageEventHandler - req: 12430002, pkg_type: tpk, pkg_name: org.example.calculator, key: end, val: ok
03-20 17:12:30.293+0900 I/Tizen::App( 1243): (78) > Installation is Completed. [Package = org.example.calculator]
03-20 17:12:30.293+0900 I/Tizen::App( 1243): (671) > Enter. package(org.example.calculator), installationResult(0)
03-20 17:12:30.293+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
03-20 17:12:30.293+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
03-20 17:12:30.293+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
03-20 17:12:30.333+0900 W/ISF_PANEL_EFL(  798): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
03-20 17:12:30.353+0900 I/Tizen::App( 1243): (1360) > package(org.example.calculator), version(1.0.0), type(tpk), displayName(calculator), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.calculator), storeClient(), appRootPath(/opt/usr/apps/org.example.calculator)
03-20 17:12:30.373+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.calculator]
03-20 17:12:30.373+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.calculator]
03-20 17:12:30.373+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
03-20 17:12:30.373+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
03-20 17:12:30.373+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.calculator]
03-20 17:12:30.383+0900 I/Tizen::App( 1243): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.calculator]
03-20 17:12:30.383+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[calculator] enable[1] system[0]
03-20 17:12:30.383+0900 E/HOME_APPS(  851): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.calculator] mdm is not enabled
03-20 17:12:30.383+0900 E/cluster-home(  851): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[calculator] enable[1] system[0]
03-20 17:12:30.393+0900 W/HOME_APPS(  851): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.calculator/shared/res/calculator.png], New icon path[/opt/usr/apps/org.example.calculator/shared/res/calculator.png]!!!!!
03-20 17:12:30.403+0900 E/PKGMGR_SERVER(10675): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10678]
03-20 17:12:30.403+0900 I/Tizen::App( 1243): (416) > appName = [calculator]
03-20 17:12:30.403+0900 I/Tizen::App( 1243): (509) > exe = [/opt/usr/apps/org.example.calculator/bin/calculator], displayName = [calculator], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
03-20 17:12:30.403+0900 E/PKGMGR_INFO( 1243): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
03-20 17:12:30.403+0900 I/Tizen::App( 1243): (683) > Application count(1) in this package
03-20 17:12:30.403+0900 I/Tizen::App( 1243): (840) > Enter.
03-20 17:12:30.413+0900 I/Tizen::App( 1243): (703) > Exit.
03-20 17:12:30.413+0900 I/Tizen::App( 1243): (1584) > Package = [org.example.calculator], Key = [end], Value = [ok], install = [96]
03-20 17:12:30.423+0900 E/util-view(  851): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
03-20 17:12:30.423+0900 I/Tizen::App( 1243): (416) > appName = [calculator]
03-20 17:12:30.423+0900 I/Tizen::App( 1243): (509) > exe = [/opt/usr/apps/org.example.calculator/bin/calculator], displayName = [calculator], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
03-20 17:12:30.423+0900 I/Tizen::App( 1243): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.calculator.info]
03-20 17:12:30.423+0900 I/Tizen::App( 1243): (131) > Enter
03-20 17:12:30.423+0900 I/Tizen::App( 1243): (137) > org.example.calculator does not have launch condition
03-20 17:12:30.423+0900 I/Tizen::App( 1243): (883) > Exit.
03-20 17:12:30.443+0900 W/HOME_APPS(  851): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.calculator/shared/res/calculator.png], Loading state:[1]
03-20 17:12:32.064+0900 E/PKGMGR_SERVER(10675): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
03-20 17:12:32.064+0900 E/PKGMGR_SERVER(10675): pkgmgr-server.c: main(2471) > package manager server terminated.
03-20 17:12:35.808+0900 W/AUL     (10733): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.calculator)
03-20 17:12:35.808+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 0
03-20 17:12:35.818+0900 I/AUL     (  629): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
03-20 17:12:35.828+0900 I/AUL     (  629): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
03-20 17:12:35.828+0900 E/AUL_AMD (  629): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
03-20 17:12:35.828+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(2508) > caller pid : 10733
03-20 17:12:35.828+0900 E/AUL_AMD (  629): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
03-20 17:12:35.838+0900 E/RESOURCED(  718): block.c: block_prelaunch_state(134) > insert data org.example.calculator, table num : 11
03-20 17:12:35.838+0900 E/RESOURCED(  718): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
03-20 17:12:35.838+0900 W/AUL_AMD (  629): amd_launch.c: _start_app(3052) > pad pid(-5)
03-20 17:12:35.838+0900 W/AUL_PAD ( 1562): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
03-20 17:12:35.838+0900 W/AUL_PAD ( 1562): launchpad.c: __send_result_to_caller(267) > Check app launching
03-20 17:12:35.858+0900 I/CAPI_APPFW_APPLICATION(10409): app_main.c: ui_app_main(789) > app_efl_main
03-20 17:12:35.858+0900 I/CAPI_APPFW_APPLICATION(10409): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
03-20 17:12:35.888+0900 E/TBM     (10409): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
03-20 17:12:35.938+0900 W/AUL     (  629): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 10409, appid: org.example.calculator
03-20 17:12:35.938+0900 E/AUL     (  629): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
03-20 17:12:35.948+0900 W/AUL     (10733): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10409)
03-20 17:12:35.948+0900 E/RESOURCED(  718): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.calculator
03-20 17:12:36.178+0900 I/APP_CORE(10409): appcore-efl.c: __do_app(514) > [APP 10409] Event: RESET State: CREATED
03-20 17:12:36.178+0900 I/CAPI_APPFW_APPLICATION(10409): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
03-20 17:12:36.178+0900 E/EFL     (10409): edje<10409> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:12:36.178+0900 E/EFL     (10409): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:12:36.178+0900 E/EFL     (10409): edje<10409> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:12:36.178+0900 E/EFL     (10409): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:12:36.178+0900 E/EFL     (10409): edje<10409> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:12:36.178+0900 E/EFL     (10409): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:12:36.178+0900 E/EFL     (10409): edje<10409> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:12:36.178+0900 E/EFL     (10409): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:12:36.178+0900 E/EFL     (10409): edje<10409> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:12:36.178+0900 E/EFL     (10409): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:12:36.208+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:12:36.208+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:12:36.229+0900 I/Tizen::System( 1243): (259) > Active app [org.exampl], current [com.samsun] 
03-20 17:12:36.229+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:12:36.229+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:12:36.239+0900 W/APP_CORE(10409): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
03-20 17:12:36.239+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 35
03-20 17:12:36.249+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:12:36.289+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: PAUSE State: RUNNING
03-20 17:12:36.289+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
03-20 17:12:36.289+0900 I/APP_CORE(10409): appcore-efl.c: __do_app(514) > [APP 10409] Event: RESUME State: CREATED
03-20 17:12:36.289+0900 E/cluster-home(  851): homescreen.cpp: OnPause(260) >  app pause
03-20 17:12:36.299+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(4)
03-20 17:12:36.299+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(851)
03-20 17:12:36.299+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: bg
03-20 17:12:36.299+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(10409) status(3)
03-20 17:12:36.299+0900 W/AUL_AMD (  629): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-20 17:12:36.299+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
03-20 17:12:36.299+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.calculator(10409)
03-20 17:12:36.299+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10409, appid: org.example.calculator, status: fg
03-20 17:12:36.309+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
03-20 17:12:36.309+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
03-20 17:12:36.309+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: bg
03-20 17:12:36.309+0900 I/APP_CORE(10409): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
03-20 17:12:36.309+0900 I/APP_CORE(10409): appcore-efl.c: __do_app(625) > [APP 10409] Initial Launching, call the resume_cb
03-20 17:12:36.309+0900 I/CAPI_APPFW_APPLICATION(10409): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:12:36.649+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(10409) status(0)
03-20 17:12:36.999+0900 E/RESOURCED(  718): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.918
03-20 17:12:37.009+0900 I/Tizen::App( 1243): (499) > LaunchedApp(org.example.calculator)
03-20 17:12:37.009+0900 I/Tizen::App( 1243): (733) > Finished invoking application event listener for org.example.calculator, 10409.
03-20 17:12:37.730+0900 I/UXT     (10742): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
03-20 17:12:38.941+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31116880
03-20 17:12:39.011+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31116956
03-20 17:12:39.021+0900 E/VCONF   (10409): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
03-20 17:12:39.021+0900 E/VCONF   (10409): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
03-20 17:12:39.021+0900 E/VCONF   (10409): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
03-20 17:12:39.021+0900 E/VCONF   (10409): vconf.c: vconf_get_bool(2729) > vconf_get_bool(10409) : db/ise/keysound error
03-20 17:12:39.021+0900 E/VCONF   (10409): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
03-20 17:12:39.021+0900 E/VCONF   (10409): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
03-20 17:12:39.131+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31117076
03-20 17:12:39.231+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31117173
03-20 17:12:39.442+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31117381
03-20 17:12:39.572+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31117511
03-20 17:12:39.872+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31117814
03-20 17:12:39.982+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31117923
03-20 17:12:41.303+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: MEM_FLUSH State: PAUSED
03-20 17:12:41.634+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31119572
03-20 17:12:41.744+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31119680
03-20 17:12:41.754+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:42.375+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31120309
03-20 17:12:42.465+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31120406
03-20 17:12:42.475+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:42.665+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31120602
03-20 17:12:42.785+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31120721
03-20 17:12:42.785+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:43.085+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31121024
03-20 17:12:43.205+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31121143
03-20 17:12:43.215+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:43.466+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31121402
03-20 17:12:43.576+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31121510
03-20 17:12:43.596+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:43.806+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31121739
03-20 17:12:43.896+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31121836
03-20 17:12:43.906+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:44.066+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31122000
03-20 17:12:44.166+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31122097
03-20 17:12:44.166+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:44.266+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31122206
03-20 17:12:44.376+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31122315
03-20 17:12:44.386+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:44.527+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31122467
03-20 17:12:44.617+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31122554
03-20 17:12:44.627+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:44.737+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31122674
03-20 17:12:44.827+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31122761
03-20 17:12:44.837+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:44.887+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31122826
03-20 17:12:44.997+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31122935
03-20 17:12:45.007+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:45.087+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31123022
03-20 17:12:45.177+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31123109
03-20 17:12:45.187+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:45.297+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31123229
03-20 17:12:45.367+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31123293
03-20 17:12:45.367+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:45.468+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31123403
03-20 17:12:45.548+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31123489
03-20 17:12:45.558+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:45.668+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31123609
03-20 17:12:45.738+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31123685
03-20 17:12:45.748+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:45.858+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31123794
03-20 17:12:45.938+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31123881
03-20 17:12:45.938+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:46.058+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31124001
03-20 17:12:46.148+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31124088
03-20 17:12:46.158+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:46.268+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31124208
03-20 17:12:46.368+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31124306
03-20 17:12:46.378+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:46.489+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31124426
03-20 17:12:46.569+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31124502
03-20 17:12:46.569+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:46.689+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31124622
03-20 17:12:46.759+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31124698
03-20 17:12:46.759+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:46.869+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31124807
03-20 17:12:46.969+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31124905
03-20 17:12:46.979+0900 E/EFL     (10409): <10409> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
03-20 17:12:47.459+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=31125401
03-20 17:12:47.580+0900 E/EFL     (10409): ecore_x<10409> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=31125521
03-20 17:12:47.590+0900 E/EFL     (10409): <10409> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
03-20 17:12:47.710+0900 I/AUL_PAD ( 1562): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10409 pgid = 10409
03-20 17:12:47.710+0900 I/AUL_PAD ( 1562): sigchild.h: __sigchild_action(143) > dead_pid(10409)
03-20 17:12:47.720+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:12:47.740+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(3)
03-20 17:12:47.740+0900 W/AUL_AMD (  629): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-20 17:12:47.740+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
03-20 17:12:47.740+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(851)
03-20 17:12:47.740+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: fg
03-20 17:12:47.780+0900 I/AUL_PAD ( 1562): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
03-20 17:12:47.780+0900 I/AUL_PAD ( 1562): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
03-20 17:12:47.780+0900 E/AUL_PAD ( 1562): launchpad.c: main(698) > error reading sigchld info
03-20 17:12:47.780+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
03-20 17:12:47.780+0900 I/ESD     (  905): esd_main.c: __esd_app_dead_handler(1773) > pid: 10409
03-20 17:12:47.780+0900 I/Tizen::App( 1243): (243) > App[org.example.calculator] pid[10409] terminate event is forwarded
03-20 17:12:47.780+0900 I/Tizen::System( 1243): (256) > osp.accessorymanager.service provider is found.
03-20 17:12:47.780+0900 I/Tizen::System( 1243): (196) > Accessory Owner is removed [org.example.calculator, 10409, ]
03-20 17:12:47.780+0900 I/Tizen::System( 1243): (256) > osp.system.service provider is found.
03-20 17:12:47.780+0900 I/Tizen::App( 1243): (506) > TerminatedApp(org.example.calculator)
03-20 17:12:47.780+0900 I/Tizen::App( 1243): (512) > Not registered pid(10409)
03-20 17:12:47.780+0900 I/Tizen::System( 1243): (246) > Terminated app [org.example.calculator]
03-20 17:12:47.790+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:12:47.790+0900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10409
03-20 17:12:47.790+0900 W/AUL_AMD (  629): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10409
03-20 17:12:47.800+0900 E/RESOURCED(  718): datausage-common.c: app_terminated_cb(643) > No classid to terminate!
03-20 17:12:47.800+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:12:47.800+0900 I/Tizen::App( 1243): (782) > Finished invoking application event listener for org.example.calculator, 10409.
03-20 17:12:47.810+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: RESUME State: PAUSED
03-20 17:12:47.810+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:12:47.810+0900 E/cluster-home(  851): homescreen.cpp: OnResume(233) >  app resume
03-20 17:12:47.810+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:12:47.840+0900 I/Tizen::System( 1243): (259) > Active app [com.samsun], current [org.exampl] 
03-20 17:12:47.840+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:12:47.840+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
03-20 17:12:47.840+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
03-20 17:12:47.840+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: fg
03-20 17:12:47.850+0900 W/CRASH_MANAGER(10750): worker.c: worker_job(1199) > 111040963616c145846156
