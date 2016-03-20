S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDU0BOL4
Build-Date: 2015.12.24 17:18:01

Crash Information
Process Name: calculator
PID: 10047
Date: 2016-03-20 17:08:38+0900
Executable File Path: /opt/usr/apps/org.example.calculator/bin/calculator
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10047, uid 5000)

Register Information
r0   = 0xfffffff8, r1   = 0x00000000
r2   = 0xb7ce8400, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb8f33ea0
r6   = 0xb8f305f0, r7   = 0xbe9411f0
r8   = 0x800148a5, r9   = 0xb5ea2708
r10  = 0xb8f22948, fp   = 0xb5f7b640
ip   = 0xffffffff, sp   = 0xbe9411b8
lr   = 0xb27b6a3d, pc   = 0xb66b40e4
cpsr = 0x600b0030

Memory Information
MemTotal:   987012 KB
MemFree:     74664 KB
Buffers:     52432 KB
Cached:     335420 KB
VmPeak:     125468 KB
VmSize:     125464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22656 KB
VmRSS:       22656 KB
VmData:      41488 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35696 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10047 TID = 10047
10047 10049 10371 10372 10376 

Maps Information
afa81000 b0280000 rw-p [stack:10376]
b12db000 b1ada000 rw-p [stack:10372]
b1b1d000 b1b2e000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b3e000 b1b43000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1b53000 b1b5b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b6c000 b1b6d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b7d000 b1b91000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1ba5000 b1ba6000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bb6000 b1bb9000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bca000 b1bcb000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bdb000 b1bdd000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bed000 b1bef000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bff000 b1c0f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c1f000 b1c2b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c3d000 b243c000 rw-p [stack:10371]
b276d000 b2774000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2785000 b278d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b279f000 b27a5000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27b5000 b27b7000 r-xp /opt/usr/apps/org.example.calculator/bin/calculator
b2907000 b29ea000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a21000 b2a49000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a5b000 b325a000 rw-p [stack:10049]
b325a000 b325c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b326c000 b3276000 r-xp /lib/libnss_files-2.20-2014.11.so
b3287000 b3290000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32a1000 b32b2000 r-xp /lib/libnsl-2.20-2014.11.so
b32c5000 b32cb000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32dc000 b32dd000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3305000 b330c000 r-xp /usr/lib/libminizip.so.1.0.0
b331c000 b3321000 r-xp /usr/lib/libstorage.so.0.1
b3331000 b3390000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33a6000 b33ba000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33ca000 b340e000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b341e000 b3426000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3436000 b3466000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3479000 b3532000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3546000 b3599000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35aa000 b35c5000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35d5000 b3696000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36a9000 b36b9000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36c9000 b36d6000 r-xp /usr/lib/libmdm-common.so.1.0.97
b36e7000 b36ee000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36fe000 b373f000 r-xp /usr/lib/libmdm.so.1.2.12
b374f000 b3757000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3766000 b3776000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3797000 b37f7000 r-xp /usr/lib/libasound.so.2.0.0
b3809000 b380c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b381c000 b381f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b382f000 b3834000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3844000 b3845000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3855000 b385f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3873000 b387a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b388a000 b3890000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38a0000 b38a5000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38b5000 b38cf000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38e0000 b38e7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38f7000 b38fa000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b390b000 b3939000 r-xp /usr/lib/libidn.so.11.5.44
b3949000 b395f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3970000 b397a000 r-xp /usr/lib/libcares.so.2.1.0
b398a000 b3994000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b39a4000 b39a6000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39b6000 b39b7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39c7000 b39cb000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39dc000 b3a04000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a15000 b3a3e000 r-xp /usr/lib/libturbojpeg.so
b3a5e000 b3a64000 r-xp /usr/lib/libgif.so.4.1.6
b3a74000 b3aba000 r-xp /usr/lib/libcurl.so.4.3.0
b3acb000 b3aec000 r-xp /usr/lib/libexif.so.12.3.3
b3b07000 b3b1c000 r-xp /usr/lib/libtts.so
b3b2d000 b3b35000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b45000 b3c0b000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c2b000 b3d23000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d42000 b3e10000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e27000 b3e29000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e39000 b3e3f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e4f000 b3e72000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e83000 b3e85000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e95000 b3e97000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ea8000 b3ead000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ec4000 b3ec6000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ed6000 b3edd000 r-xp /usr/lib/libsensord-share.so
b3eed000 b3f05000 r-xp /usr/lib/libsensor.so.1.1.0
b3f16000 b3f19000 r-xp /usr/lib/libXv.so.1.0.0
b3f29000 b3f2e000 r-xp /usr/lib/libutilX.so.1.1.0
b3f3e000 b3f43000 r-xp /usr/lib/libappcore-common.so.1.1
b3f53000 b3f5a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f6d000 b3f71000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f82000 b4060000 r-xp /usr/lib/libCOREGL.so.4.0
b4080000 b4083000 r-xp /usr/lib/libuuid.so.1.3.0
b4093000 b40aa000 r-xp /usr/lib/libblkid.so.1.1.0
b40bb000 b40bd000 r-xp /usr/lib/libXau.so.6.0.0
b40cd000 b4114000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4126000 b412c000 r-xp /usr/lib/libjson-c.so.2.0.1
b413d000 b4141000 r-xp /usr/lib/libogg.so.0.7.1
b4151000 b4173000 r-xp /usr/lib/libvorbis.so.0.4.3
b4183000 b4267000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4283000 b4286000 r-xp /usr/lib/libEGL.so.1.4
b4297000 b429d000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42ad000 b42af000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42bf000 b42cc000 r-xp /usr/lib/libGLESv2.so.2.0
b42dd000 b433f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4354000 b436c000 r-xp /usr/lib/libmount.so.1.1.0
b437e000 b4392000 r-xp /usr/lib/libxcb.so.1.1.0
b43a2000 b43a9000 r-xp /lib/libcrypt-2.20-2014.11.so
b43e1000 b43e3000 r-xp /usr/lib/libiri.so
b43f3000 b43fe000 r-xp /usr/lib/libgpg-error.so.0.15.0
b440f000 b4445000 r-xp /usr/lib/libpulse.so.0.16.2
b4456000 b4499000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ae000 b44c3000 r-xp /lib/libexpat.so.1.5.2
b44d5000 b4593000 r-xp /usr/lib/libcairo.so.2.11200.14
b45a7000 b45af000 r-xp /usr/lib/libdrm.so.2.4.0
b45bf000 b45c2000 r-xp /usr/lib/libdri2.so.0.0.0
b45d2000 b4620000 r-xp /usr/lib/libssl.so.1.0.0
b4635000 b4641000 r-xp /usr/lib/libeeze.so.1.13.0
b4652000 b465b000 r-xp /usr/lib/libethumb.so.1.13.0
b466b000 b466e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b467e000 b4835000 r-xp /usr/lib/libcrypto.so.1.0.0
b5620000 b5629000 r-xp /usr/lib/libXi.so.6.1.0
b5639000 b563b000 r-xp /usr/lib/libXgesture.so.7.0.0
b564b000 b564f000 r-xp /usr/lib/libXtst.so.6.1.0
b565f000 b5665000 r-xp /usr/lib/libXrender.so.1.3.0
b5675000 b567b000 r-xp /usr/lib/libXrandr.so.2.2.0
b568b000 b568d000 r-xp /usr/lib/libXinerama.so.1.0.0
b569e000 b56a1000 r-xp /usr/lib/libXfixes.so.3.1.0
b56b1000 b56bc000 r-xp /usr/lib/libXext.so.6.4.0
b56cc000 b56ce000 r-xp /usr/lib/libXdamage.so.1.1.0
b56de000 b56e0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56f0000 b57d2000 r-xp /usr/lib/libX11.so.6.3.0
b57e6000 b57ed000 r-xp /usr/lib/libXcursor.so.1.0.2
b57fd000 b5815000 r-xp /usr/lib/libudev.so.1.6.0
b5817000 b581a000 r-xp /lib/libattr.so.1.1.0
b582a000 b584a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b584b000 b5850000 r-xp /usr/lib/libffi.so.6.0.2
b5861000 b5879000 r-xp /lib/libz.so.1.2.8
b5889000 b588b000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b589b000 b5970000 r-xp /usr/lib/libxml2.so.2.9.2
b5985000 b5a20000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a3c000 b5a3f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a4f000 b5a68000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a79000 b5a8a000 r-xp /lib/libresolv-2.20-2014.11.so
b5a9e000 b5b18000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b2d000 b5b2f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b3f000 b5b46000 r-xp /usr/lib/libembryo.so.1.13.0
b5b56000 b5b60000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b71000 b5b89000 r-xp /usr/lib/libpng12.so.0.50.0
b5b9a000 b5bbd000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bde000 b5bf2000 r-xp /usr/lib/libector.so.1.13.0
b5c03000 b5c1b000 r-xp /usr/lib/liblua-5.1.so
b5c2c000 b5c83000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c97000 b5cbf000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cd0000 b5ce3000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cf4000 b5d2e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d3f000 b5d4d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d5d000 b5d65000 r-xp /usr/lib/libtbm.so.1.0.0
b5d75000 b5d82000 r-xp /usr/lib/libeio.so.1.13.0
b5d92000 b5d94000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5da4000 b5da9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5db9000 b5dd0000 r-xp /usr/lib/libefreet.so.1.13.0
b5de2000 b5e02000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e12000 b5e32000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e34000 b5e3a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e4a000 b5e5b000 r-xp /usr/lib/libemotion.so.1.13.0
b5e6c000 b5e73000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e83000 b5e92000 r-xp /usr/lib/libeo.so.1.13.0
b5ea3000 b5eb5000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ec6000 b5ecb000 r-xp /usr/lib/libecore_file.so.1.13.0
b5edb000 b5ef4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f04000 b5f21000 r-xp /usr/lib/libeet.so.1.13.0
b5f3a000 b5f82000 r-xp /usr/lib/libeina.so.1.13.0
b5f93000 b5fa3000 r-xp /usr/lib/libefl.so.1.13.0
b5fb4000 b6099000 r-xp /usr/lib/libicuuc.so.51.1
b60b6000 b61f6000 r-xp /usr/lib/libicui18n.so.51.1
b620d000 b6245000 r-xp /usr/lib/libecore_x.so.1.13.0
b6257000 b625a000 r-xp /lib/libcap.so.2.21
b626a000 b6293000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62a4000 b62ab000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62bd000 b62f4000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6305000 b63f0000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6403000 b647c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b648e000 b6493000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64a3000 b64ad000 r-xp /usr/lib/libvconf.so.0.2.45
b64bd000 b64bf000 r-xp /usr/lib/libvasum.so.0.3.1
b64cf000 b64d1000 r-xp /usr/lib/libttrace.so.1.1
b64e1000 b64e4000 r-xp /usr/lib/libiniparser.so.0
b64f4000 b6519000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b652a000 b652f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6540000 b6557000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6568000 b65d3000 r-xp /lib/libm-2.20-2014.11.so
b65e4000 b65ea000 r-xp /lib/librt-2.20-2014.11.so
b65fb000 b6608000 r-xp /usr/lib/libunwind.so.8.0.1
b663e000 b6762000 r-xp /lib/libc-2.20-2014.11.so
b6777000 b6790000 r-xp /lib/libgcc_s-4.9.so.1
b67a0000 b6882000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6893000 b68bd000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ce000 b690a000 r-xp /usr/lib/libsystemd.so.0.4.0
b690c000 b698f000 r-xp /usr/lib/libedje.so.1.13.0
b69a2000 b69c0000 r-xp /usr/lib/libecore.so.1.13.0
b69e0000 b6b67000 r-xp /usr/lib/libevas.so.1.13.0
b6b9c000 b6bb0000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc4000 b6df8000 r-xp /usr/lib/libelementary.so.1.13.0
b6e27000 b6e2b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e3b000 b6e42000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e52000 b6e54000 r-xp /usr/lib/libdlog.so.0.0.0
b6e64000 b6e67000 r-xp /usr/lib/libbundle.so.0.1.22
b6e77000 b6e79000 r-xp /lib/libdl-2.20-2014.11.so
b6e8a000 b6ea2000 r-xp /usr/lib/libaul.so.0.1.0
b6eb6000 b6ebb000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ecc000 b6ed9000 r-xp /usr/lib/liblptcp.so
b6eeb000 b6eef000 r-xp /usr/lib/libsys-assert.so
b6f00000 b6f20000 r-xp /lib/ld-2.20-2014.11.so
b6f31000 b6f36000 r-xp /usr/bin/launchpad-loader
b8cd0000 b900b000 rw-p [heap]
be921000 be942000 rw-p [stack]
b8cd0000 b900b000 rw-p [heap]
be921000 be942000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10047)
Call Stack Count: 1
 0: strlen + 0x23 (0xb66b40e4) [/lib/libc.so.6] + 0x760e4
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
1604) > [account_query_account_by_account_id:1604] account_query_account_by_account_id end
03-20 17:06:42.113+0900 I/ACCOUNT ( 9914): account.c: account_destroy(805) > [account_destroy:805] account_destroy start
03-20 17:06:42.113+0900 I/ACCOUNT ( 9914): account.c: account_destroy(813) > [account_destroy:813] account_destroy end
03-20 17:06:42.133+0900 I/PHONE   ( 9914): CtListView.cpp: __onInitMyProfileThreadEndCb(597) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.133+0900 I/PHONE   ( 9914): CtThread.cpp: destroy(66) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.143+0900 I/PHONE   ( 9914): CtListMyProfileItem.hpp: __checkNameExist(277) > [0;32mBEGIN >>>>[0;m
03-20 17:06:42.493+0900 I/UXT     (10069): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
03-20 17:06:42.543+0900 E/TBM     (10069): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
03-20 17:06:42.543+0900 I/MALI    (10069): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=10069   open drm_fd=30 
03-20 17:06:42.614+0900 I/PHONE   ( 9914): CtTabView.cpp: __createRestViewTimerCb(474) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.664+0900 E/EFL     (10069): edje<10069> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:42.664+0900 E/EFL     (10069): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:42.664+0900 E/EFL     (10069): edje<10069> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:42.664+0900 E/EFL     (10069): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:42.664+0900 E/EFL     (10069): edje<10069> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
03-20 17:06:42.664+0900 E/EFL     (10069): By the power of Grayskull, your previous Embryo stack is now broken!
03-20 17:06:42.924+0900 E/EFL     ( 9914): ecore_x<9914> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30760671
03-20 17:06:42.924+0900 E/EFL     ( 9914): ecore_x<9914> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30760861
03-20 17:06:42.924+0900 I/PHONE   ( 9914): CtTabView.cpp: onPop(233) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.924+0900 I/PHONE   ( 9914): PhDialerView.cpp: onTabPop(161) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.924+0900 I/PHONE   ( 9914): PhLogMainListView.cpp: onTabPop(543) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.924+0900 I/PHONE   ( 9914): CtListView.cpp: onTabPop(1485) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.924+0900 I/PHONE   ( 9914): CtListView.cpp: __cleanSearchbar(2271) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.924+0900 I/PHONE   ( 9914): CtListSearchBarControl.hpp: clear(64) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.924+0900 E/PHONE   ( 9914): CtListView.cpp: __clearGalSearchItems(4922) > [0;31m* Critical * __galSearchTitleItem is NULL[0;m
03-20 17:06:42.924+0900 I/WAPP    ( 9914): WNaviframe.cpp: onLastItemPop(252) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.924+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(3)
03-20 17:06:42.924+0900 W/AUL_AMD (  629): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-20 17:06:42.924+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
03-20 17:06:42.924+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(851)
03-20 17:06:42.924+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: fg
03-20 17:06:42.954+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 36
03-20 17:06:42.954+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
03-20 17:06:42.984+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:42.984+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:42.994+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: RESUME State: PAUSED
03-20 17:06:42.994+0900 I/APP_CORE( 9914): appcore-efl.c: __do_app(514) > [APP 9914] Event: PAUSE State: RUNNING
03-20 17:06:42.994+0900 I/CAPI_APPFW_APPLICATION( 9914): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
03-20 17:06:42.994+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:06:42.994+0900 I/WAPP    ( 9914): WApp.cpp: __onPause(79) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.994+0900 I/PHONE   ( 9914): ContactsApp.cpp: onPause(73) > [0;34m>>>HIT<<<[0;m
03-20 17:06:42.994+0900 E/cluster-home(  851): homescreen.cpp: OnResume(233) >  app resume
03-20 17:06:42.994+0900 W/UI_GADGET( 9914): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
03-20 17:06:43.004+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(9914) status(4)
03-20 17:06:43.004+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.contacts(9914)
03-20 17:06:43.004+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9914, appid: com.samsung.contacts, status: bg
03-20 17:06:43.014+0900 I/Tizen::System( 1243): (259) > Active app [com.samsun], current [com.samsun] 
03-20 17:06:43.014+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=1, ret=0x0
03-20 17:06:43.014+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:06:43.024+0900 I/TIZEN_N_SOUND_MANAGER(  934): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=1, ret=0x0
03-20 17:06:43.024+0900 E/TIZEN_N_SOUND_MANAGER(  934): sound_manager_private.c: __convert_sound_manager_error_code(85) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-20 17:06:43.024+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 15
03-20 17:06:43.044+0900 I/Tizen::System( 1243): (273) > Current App[com.samsun] is already actived.
03-20 17:06:43.054+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
03-20 17:06:43.054+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
03-20 17:06:43.054+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: fg
03-20 17:06:43.054+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30760922
03-20 17:06:43.054+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30760986
03-20 17:06:43.054+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
03-20 17:06:43.054+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
03-20 17:06:43.064+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
03-20 17:06:43.064+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
03-20 17:06:43.074+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:43.084+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
03-20 17:06:43.084+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
03-20 17:06:43.084+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: bg
03-20 17:06:43.084+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:43.154+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 9914): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 159
03-20 17:06:43.154+0900 E/APP_CORE( 9914): appcore-efl.c: _capture_and_make_file(1619) > win[6800003] widget[720] height[1280]
03-20 17:06:43.154+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 33
03-20 17:06:43.214+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30761057
03-20 17:06:43.214+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
03-20 17:06:43.214+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
03-20 17:06:43.224+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30761136
03-20 17:06:43.224+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
03-20 17:06:43.224+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
03-20 17:06:43.244+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
03-20 17:06:43.244+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
03-20 17:06:43.244+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: fg
03-20 17:06:43.264+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:43.264+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.245+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.245+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.265+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.265+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.285+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.285+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.305+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.305+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.315+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.325+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.335+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.345+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.355+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.355+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.375+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.375+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.395+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.395+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.415+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.415+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.425+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.435+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:44.445+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:44.445+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:48.009+0900 I/APP_CORE( 9914): appcore-efl.c: __do_app(514) > [APP 9914] Event: MEM_FLUSH State: PAUSED
03-20 17:07:00.981+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(195) > ""
03-20 17:07:00.981+0900 E/UXT     (  714): uxt_date_time.c: uxt_date_time_get_format_by_locale(244) > format : %Y/%m/%d%p%l:%M
03-20 17:07:00.981+0900 E/UXT     (  714): uxt_util.c: uxt_util_get_date_time_text_by_locale(390) > text : 오후 5:07
03-20 17:07:00.981+0900 I/INDICATOR(  714): clock.c: getTimeFormatted(176) > "time format : 오후 5:07"
03-20 17:07:00.981+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 5:07"
03-20 17:07:00.981+0900 W/INDICATOR(  714): clock.c: indicator_clock_changed_cb(272) > 
03-20 17:07:00.981+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147477204 Time: <font_size=31> </font_size> <font_size=31> 오후 5:07</font_size></font>"
03-20 17:07:58.267+0900 I/Tizen::Net::Wifi( 1243): (941) > The background scan result updated.
03-20 17:08:00.990+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(195) > ""
03-20 17:08:00.990+0900 E/UXT     (  714): uxt_date_time.c: uxt_date_time_get_format_by_locale(244) > format : %Y/%m/%d%p%l:%M
03-20 17:08:00.990+0900 E/UXT     (  714): uxt_util.c: uxt_util_get_date_time_text_by_locale(390) > text : 오후 5:08
03-20 17:08:00.990+0900 I/INDICATOR(  714): clock.c: getTimeFormatted(176) > "time format : 오후 5:08"
03-20 17:08:00.990+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 5:08"
03-20 17:08:00.990+0900 W/INDICATOR(  714): clock.c: indicator_clock_changed_cb(272) > 
03-20 17:08:00.990+0900 I/INDICATOR(  714): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145407696 Time: <font_size=31> </font_size> <font_size=31> 오후 5:08</font_size></font>"
03-20 17:08:11.911+0900 E/PKGMGR_SERVER(10158): pkgmgr-server.c: main(2414) > package manager server start
03-20 17:08:11.971+0900 E/PKGMGR  (10156): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.calculator, -1]
03-20 17:08:12.001+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 14
03-20 17:08:12.011+0900 W/AUL_AMD (  629): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
03-20 17:08:12.021+0900 E/PKGMGR_SERVER(10158): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10161]
03-20 17:08:12.141+0900 I/SERVICE_MANAGER_LIB(10070): service-manager.c: service_manager_unregister_listener2(564) > [34m[10070]service_manager_unregister_object[0m
03-20 17:08:14.063+0900 E/PKGMGR_SERVER(10158): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
03-20 17:08:14.063+0900 E/PKGMGR_SERVER(10158): pkgmgr-server.c: main(2471) > package manager server terminated.
03-20 17:08:18.587+0900 E/PKGMGR  (10248): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
03-20 17:08:18.667+0900 E/PKGMGR_SERVER(10250): pkgmgr-server.c: main(2414) > package manager server start
03-20 17:08:18.717+0900 E/PKGMGR_SERVER(10250): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.calculator]
03-20 17:08:18.727+0900 E/PKGMGR_SERVER(10250): pm-mdm.c: _get_package_info_from_file(115) > [0;31m[_get_package_info_from_file(): 115](ret < 0) access() failed. path: org.example.calculator errno: 2 (No such file or directory)[0;m
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
03-20 17:08:39.117+0900 W/CRASH_MANAGER(10379): worker.c: worker_job(1199) > 111004763616c145846131
