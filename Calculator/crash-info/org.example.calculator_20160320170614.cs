S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDU0BOL4
Build-Date: 2015.12.24 17:18:01

Crash Information
Process Name: calculator
PID: 9604
Date: 2016-03-20 17:06:14+0900
Executable File Path: /opt/usr/apps/org.example.calculator/bin/calculator
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9604, uid 5000)

Register Information
r0   = 0xfffffff8, r1   = 0x00000000
r2   = 0xbc7d6f00, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb8d7c918
r6   = 0xb8d90e68, r7   = 0xbeaad1f0
r8   = 0x800148a5, r9   = 0xb5f02708
r10  = 0xb8d7c940, fp   = 0xb5fdb640
ip   = 0xffffffff, sp   = 0xbeaad1b8
lr   = 0xb2816a3d, pc   = 0xb67140e4
cpsr = 0x600b0030

Memory Information
MemTotal:   987012 KB
MemFree:     85004 KB
Buffers:     51652 KB
Cached:     333860 KB
VmPeak:     137928 KB
VmSize:     125596 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27880 KB
VmRSS:       23092 KB
VmData:      41624 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35696 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9604 TID = 9604
9604 9605 9897 9898 9909 

Maps Information
afa81000 b0280000 rw-p [stack:9909]
b133b000 b1b3a000 rw-p [stack:9898]
b1b7d000 b1b8e000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b9e000 b1ba3000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1bb3000 b1bbb000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bcc000 b1bcd000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bdd000 b1bf1000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c05000 b1c06000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c16000 b1c19000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c2a000 b1c2b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c3b000 b1c3d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c4d000 b1c4f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c5f000 b1c6f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c7f000 b1c8b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c9d000 b249c000 rw-p [stack:9897]
b27cd000 b27d4000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27e5000 b27ed000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27ff000 b2805000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2815000 b2817000 r-xp /opt/usr/apps/org.example.calculator/bin/calculator
b2967000 b2a4a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a81000 b2aa9000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2abb000 b32ba000 rw-p [stack:9605]
b32ba000 b32bc000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32cc000 b32d6000 r-xp /lib/libnss_files-2.20-2014.11.so
b32e7000 b32f0000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3301000 b3312000 r-xp /lib/libnsl-2.20-2014.11.so
b3325000 b332b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b333c000 b333d000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3365000 b336c000 r-xp /usr/lib/libminizip.so.1.0.0
b337c000 b3381000 r-xp /usr/lib/libstorage.so.0.1
b3391000 b33f0000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3406000 b341a000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b342a000 b346e000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b347e000 b3486000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3496000 b34c6000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34d9000 b3592000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35a6000 b35f9000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b360a000 b3625000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3635000 b36f6000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3709000 b3719000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3729000 b3736000 r-xp /usr/lib/libmdm-common.so.1.0.97
b3747000 b374e000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b375e000 b379f000 r-xp /usr/lib/libmdm.so.1.2.12
b37af000 b37b7000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37c6000 b37d6000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37f7000 b3857000 r-xp /usr/lib/libasound.so.2.0.0
b3869000 b386c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b387c000 b387f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b388f000 b3894000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38a4000 b38a5000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38b5000 b38bf000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38d3000 b38da000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38ea000 b38f0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3900000 b3905000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3915000 b392f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3940000 b3947000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3957000 b395a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b396b000 b3999000 r-xp /usr/lib/libidn.so.11.5.44
b39a9000 b39bf000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39d0000 b39da000 r-xp /usr/lib/libcares.so.2.1.0
b39ea000 b39f4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b3a04000 b3a06000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a16000 b3a17000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a27000 b3a2b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a3c000 b3a64000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a75000 b3a9e000 r-xp /usr/lib/libturbojpeg.so
b3abe000 b3ac4000 r-xp /usr/lib/libgif.so.4.1.6
b3ad4000 b3b1a000 r-xp /usr/lib/libcurl.so.4.3.0
b3b2b000 b3b4c000 r-xp /usr/lib/libexif.so.12.3.3
b3b67000 b3b7c000 r-xp /usr/lib/libtts.so
b3b8d000 b3b95000 r-xp /usr/lib/libfeedback.so.0.1.4
b3ba5000 b3c6b000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c8b000 b3d83000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3da2000 b3e70000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e87000 b3e89000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e99000 b3e9f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eaf000 b3ed2000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ee3000 b3ee5000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ef5000 b3ef7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f08000 b3f0d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f24000 b3f26000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f36000 b3f3d000 r-xp /usr/lib/libsensord-share.so
b3f4d000 b3f65000 r-xp /usr/lib/libsensor.so.1.1.0
b3f76000 b3f79000 r-xp /usr/lib/libXv.so.1.0.0
b3f89000 b3f8e000 r-xp /usr/lib/libutilX.so.1.1.0
b3f9e000 b3fa3000 r-xp /usr/lib/libappcore-common.so.1.1
b3fb3000 b3fba000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fcd000 b3fd1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fe2000 b40c0000 r-xp /usr/lib/libCOREGL.so.4.0
b40e0000 b40e3000 r-xp /usr/lib/libuuid.so.1.3.0
b40f3000 b410a000 r-xp /usr/lib/libblkid.so.1.1.0
b411b000 b411d000 r-xp /usr/lib/libXau.so.6.0.0
b412d000 b4174000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4186000 b418c000 r-xp /usr/lib/libjson-c.so.2.0.1
b419d000 b41a1000 r-xp /usr/lib/libogg.so.0.7.1
b41b1000 b41d3000 r-xp /usr/lib/libvorbis.so.0.4.3
b41e3000 b42c7000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42e3000 b42e6000 r-xp /usr/lib/libEGL.so.1.4
b42f7000 b42fd000 r-xp /usr/lib/libxcb-render.so.0.0.0
b430d000 b430f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b431f000 b432c000 r-xp /usr/lib/libGLESv2.so.2.0
b433d000 b439f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43b4000 b43cc000 r-xp /usr/lib/libmount.so.1.1.0
b43de000 b43f2000 r-xp /usr/lib/libxcb.so.1.1.0
b4402000 b4409000 r-xp /lib/libcrypt-2.20-2014.11.so
b4441000 b4443000 r-xp /usr/lib/libiri.so
b4453000 b445e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b446f000 b44a5000 r-xp /usr/lib/libpulse.so.0.16.2
b44b6000 b44f9000 r-xp /usr/lib/libsndfile.so.1.0.25
b450e000 b4523000 r-xp /lib/libexpat.so.1.5.2
b4535000 b45f3000 r-xp /usr/lib/libcairo.so.2.11200.14
b4607000 b460f000 r-xp /usr/lib/libdrm.so.2.4.0
b461f000 b4622000 r-xp /usr/lib/libdri2.so.0.0.0
b4632000 b4680000 r-xp /usr/lib/libssl.so.1.0.0
b4695000 b46a1000 r-xp /usr/lib/libeeze.so.1.13.0
b46b2000 b46bb000 r-xp /usr/lib/libethumb.so.1.13.0
b46cb000 b46ce000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46de000 b4895000 r-xp /usr/lib/libcrypto.so.1.0.0
b5680000 b5689000 r-xp /usr/lib/libXi.so.6.1.0
b5699000 b569b000 r-xp /usr/lib/libXgesture.so.7.0.0
b56ab000 b56af000 r-xp /usr/lib/libXtst.so.6.1.0
b56bf000 b56c5000 r-xp /usr/lib/libXrender.so.1.3.0
b56d5000 b56db000 r-xp /usr/lib/libXrandr.so.2.2.0
b56eb000 b56ed000 r-xp /usr/lib/libXinerama.so.1.0.0
b56fe000 b5701000 r-xp /usr/lib/libXfixes.so.3.1.0
b5711000 b571c000 r-xp /usr/lib/libXext.so.6.4.0
b572c000 b572e000 r-xp /usr/lib/libXdamage.so.1.1.0
b573e000 b5740000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5750000 b5832000 r-xp /usr/lib/libX11.so.6.3.0
b5846000 b584d000 r-xp /usr/lib/libXcursor.so.1.0.2
b585d000 b5875000 r-xp /usr/lib/libudev.so.1.6.0
b5877000 b587a000 r-xp /lib/libattr.so.1.1.0
b588a000 b58aa000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ab000 b58b0000 r-xp /usr/lib/libffi.so.6.0.2
b58c1000 b58d9000 r-xp /lib/libz.so.1.2.8
b58e9000 b58eb000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58fb000 b59d0000 r-xp /usr/lib/libxml2.so.2.9.2
b59e5000 b5a80000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a9c000 b5a9f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aaf000 b5ac8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad9000 b5aea000 r-xp /lib/libresolv-2.20-2014.11.so
b5afe000 b5b78000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b8d000 b5b8f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b9f000 b5ba6000 r-xp /usr/lib/libembryo.so.1.13.0
b5bb6000 b5bc0000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bd1000 b5be9000 r-xp /usr/lib/libpng12.so.0.50.0
b5bfa000 b5c1d000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c3e000 b5c52000 r-xp /usr/lib/libector.so.1.13.0
b5c63000 b5c7b000 r-xp /usr/lib/liblua-5.1.so
b5c8c000 b5ce3000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf7000 b5d1f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d30000 b5d43000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d54000 b5d8e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d9f000 b5dad000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dbd000 b5dc5000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd5000 b5de2000 r-xp /usr/lib/libeio.so.1.13.0
b5df2000 b5df4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e04000 b5e09000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e19000 b5e30000 r-xp /usr/lib/libefreet.so.1.13.0
b5e42000 b5e62000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e72000 b5e92000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e94000 b5e9a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eaa000 b5ebb000 r-xp /usr/lib/libemotion.so.1.13.0
b5ecc000 b5ed3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee3000 b5ef2000 r-xp /usr/lib/libeo.so.1.13.0
b5f03000 b5f15000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f26000 b5f2b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f3b000 b5f54000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f64000 b5f81000 r-xp /usr/lib/libeet.so.1.13.0
b5f9a000 b5fe2000 r-xp /usr/lib/libeina.so.1.13.0
b5ff3000 b6003000 r-xp /usr/lib/libefl.so.1.13.0
b6014000 b60f9000 r-xp /usr/lib/libicuuc.so.51.1
b6116000 b6256000 r-xp /usr/lib/libicui18n.so.51.1
b626d000 b62a5000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b7000 b62ba000 r-xp /lib/libcap.so.2.21
b62ca000 b62f3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6304000 b630b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b631d000 b6354000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6365000 b6450000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6463000 b64dc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ee000 b64f3000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6503000 b650d000 r-xp /usr/lib/libvconf.so.0.2.45
b651d000 b651f000 r-xp /usr/lib/libvasum.so.0.3.1
b652f000 b6531000 r-xp /usr/lib/libttrace.so.1.1
b6541000 b6544000 r-xp /usr/lib/libiniparser.so.0
b6554000 b6579000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b658a000 b658f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65a0000 b65b7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c8000 b6633000 r-xp /lib/libm-2.20-2014.11.so
b6644000 b664a000 r-xp /lib/librt-2.20-2014.11.so
b665b000 b6668000 r-xp /usr/lib/libunwind.so.8.0.1
b669e000 b67c2000 r-xp /lib/libc-2.20-2014.11.so
b67d7000 b67f0000 r-xp /lib/libgcc_s-4.9.so.1
b6800000 b68e2000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f3000 b691d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b692e000 b696a000 r-xp /usr/lib/libsystemd.so.0.4.0
b696c000 b69ef000 r-xp /usr/lib/libedje.so.1.13.0
b6a02000 b6a20000 r-xp /usr/lib/libecore.so.1.13.0
b6a40000 b6bc7000 r-xp /usr/lib/libevas.so.1.13.0
b6bfc000 b6c10000 r-xp /lib/libpthread-2.20-2014.11.so
b6c24000 b6e58000 r-xp /usr/lib/libelementary.so.1.13.0
b6e87000 b6e8b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e9b000 b6ea2000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb2000 b6eb4000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec4000 b6ec7000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed7000 b6ed9000 r-xp /lib/libdl-2.20-2014.11.so
b6eea000 b6f02000 r-xp /usr/lib/libaul.so.0.1.0
b6f16000 b6f1b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f2c000 b6f39000 r-xp /usr/lib/liblptcp.so
b6f4b000 b6f4f000 r-xp /usr/lib/libsys-assert.so
b6f60000 b6f80000 r-xp /lib/ld-2.20-2014.11.so
b6f91000 b6f96000 r-xp /usr/bin/launchpad-loader
b8b2a000 b8e8b000 rw-p [heap]
bea8d000 beaae000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9604)
Call Stack Count: 1
 0: strlen + 0x23 (0xb67140e4) [/lib/libc.so.6] + 0x760e4
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
(  899): media-server-thumb.c: _ms_thumb_request_to_server(825) > Thumb server is not running.. so start it
03-20 17:05:57.610+0900 E/MEDIA_THUMBNAIL( 9922): media-thumb-db.c: _media_thumb_get_thumb_path_from_db(162) > [31mend of row [unknown error]
03-20 17:05:57.610+0900 W/MEDIA_THUMBNAIL( 9922): media-thumb-db.c: _media_thumb_get_thumb_from_db_with_size(408) > [32mOriginal path doesn't exist in DB
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(71) > On Media Content Data Changed
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(79) > Media Content Image Type Data Changed
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(332) > DataChangeSyncScheduler::HandleDataChangeEvent() Starts
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncManager.cpp: SendSyncCheckAlarmMessage(1018) > Fire SYNC_CHECK_ALARM 
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(137) > Adding a request to sync worker
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(152) > Added into __pendingRequests, current size = 1
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(164) > Request Successfully added
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(345) > DataChangeSyncScheduler::HandleDataChangeEvent() Ends
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(175) > GIO event received
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(201) > Popping from __pendingRequests, size = 0
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(127) > 0. Sync Job dispatcher starts
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(157) > 1. Handle Event : SYNC_CHECK_ALARM
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(158) > 2. Start next Sync job from main queue
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: TryStartingNextJobLocked(190) > No network available: Skipping sync
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(174) > 3. Sync Job dispatcher Ends
03-20 17:05:57.790+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(214) > Event handled successfully
03-20 17:05:58.250+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  327): media_content.c: media_content_connect(856) > [32m[327]ref count : 0
03-20 17:05:58.250+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  327): media_content.c: media_content_connect(888) > [32m[327]ref count changed to: 1
03-20 17:05:58.280+0900 W/MEDIA_THUMBNAIL( 9922): media-thumb-db.c: _media_thumb_get_thumb_from_db_with_size(413) > [32mthumb path doesn't exist in DB
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(71) > On Media Content Data Changed
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(79) > Media Content Image Type Data Changed
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(332) > DataChangeSyncScheduler::HandleDataChangeEvent() Starts
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncManager.cpp: SendSyncCheckAlarmMessage(1018) > Fire SYNC_CHECK_ALARM 
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(137) > Adding a request to sync worker
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(152) > Added into __pendingRequests, current size = 1
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: AddRequestN(164) > Request Successfully added
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(345) > DataChangeSyncScheduler::HandleDataChangeEvent() Ends
03-20 17:05:58.440+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  327): media_content.c: media_content_disconnect(940) > [32m[327]ref count changed to: 0
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(175) > GIO event received
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(201) > Popping from __pendingRequests, size = 0
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(127) > 0. Sync Job dispatcher starts
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(157) > 1. Handle Event : SYNC_CHECK_ALARM
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(158) > 2. Start next Sync job from main queue
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: TryStartingNextJobLocked(190) > No network available: Skipping sync
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(174) > 3. Sync Job dispatcher Ends
03-20 17:05:58.440+0900 I/SYNCSERVICE(  989): SyncManager_SyncWorker.cpp: OnEventReceived(214) > Event handled successfully
03-20 17:05:58.450+0900 I/AUL     (  327): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
03-20 17:05:58.460+0900 I/AUL     (  327): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
03-20 17:05:58.470+0900 I/AUL     (  327): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
03-20 17:05:58.480+0900 I/AUL     (  327): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
03-20 17:05:58.480+0900 E/CAPI_APPFW_APP_MANAGER(  327): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
03-20 17:05:58.490+0900 I/QUICKPANEL(  867): NotificationItemModel.cpp: __updateSmartAlert(2288) > [0;32mpackage name: shot-tizen, insert: 0[0;m
03-20 17:05:58.490+0900 I/QUICKPANEL(  867): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
03-20 17:05:58.490+0900 W/QUICKPANEL(  867): NotificationItemModel.cpp: removeNotification(286) > [0;35mEvent notification is deleted.[0;m
03-20 17:05:58.490+0900 E/INDICATOR(  714): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
03-20 17:05:58.490+0900 E/INDICATOR(  714): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
03-20 17:05:58.490+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:05:58.490+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:05:58.490+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:05:58.500+0900 E/INDICATOR(  714): ticker.c: _ticker_noti_detailed_changed_cb(1335) > check op_type
03-20 17:05:58.500+0900 I/QUICKPANEL(  867): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
03-20 17:05:58.510+0900 I/AUL     (  750): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
03-20 17:05:58.520+0900 I/AUL     (  750): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
03-20 17:05:58.531+0900 I/AUL     (  750): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
03-20 17:05:58.541+0900 I/AUL     (  750): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
03-20 17:05:58.541+0900 E/CAPI_APPFW_APP_MANAGER(  750): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
03-20 17:05:58.591+0900 E/QUICKPANEL(  867): NotificationItemModel.cpp: __playSound(1794) > [0;31m* Critical * None type: No sound[0;m
03-20 17:05:58.591+0900 I/QUICKPANEL(  867): NotificationItemModel.cpp: __updateSmartAlert(2288) > [0;32mpackage name: shot-tizen, insert: 1[0;m
03-20 17:05:58.601+0900 E/INDICATOR(  714): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
03-20 17:05:58.601+0900 E/INDICATOR(  714): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
03-20 17:05:58.601+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:05:58.601+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:05:58.601+0900 E/QUICKPANEL(  867): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
03-20 17:05:58.601+0900 E/QUICKPANEL(  867): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
03-20 17:05:58.611+0900 E/INDICATOR(  714): box.c: _update_icon(232) > (!list) -> _update_icon() return
03-20 17:05:58.611+0900 E/INDICATOR(  714): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
03-20 17:05:58.611+0900 E/QUICKPANEL(  867): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
03-20 17:05:58.611+0900 W/QUICKPANEL(  867): NotificationItemModel.cpp: __addNotification(635) > [0;35mshot-tizen - notification is inserted.[0;m
03-20 17:05:58.621+0900 I/QUICKPANEL(  867): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
03-20 17:05:58.621+0900 W/QUICKPANEL(  867): NotificationItemModel.cpp: insertNotification(235) > [0;35mEvent notification is inserted.[0;m
03-20 17:05:58.621+0900 E/EFL     (  867): eo<867> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
03-20 17:05:58.621+0900 I/QUICKPANEL(  867): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
03-20 17:05:58.651+0900 E/EFL     (  867): edje<867> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/listitem/notification has a non-fixed part 'elm.text.time'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
03-20 17:06:00.442+0900 W/AUL_AMD (  629): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
03-20 17:06:00.472+0900 E/EFL     ( 8537): ecore_x<8537> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30718391
03-20 17:06:00.472+0900 E/EFL     ( 8537): ecore_x<8537> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30718410
03-20 17:06:00.482+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(3)
03-20 17:06:00.482+0900 W/AUL_AMD (  629): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-20 17:06:00.482+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
03-20 17:06:00.482+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(851)
03-20 17:06:00.482+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 851, appid: com.samsung.homescreen, status: fg
03-20 17:06:00.542+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:00.542+0900 E/EFL     (  327): eo<327> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
03-20 17:06:00.562+0900 I/APP_CORE(  851): appcore-efl.c: __do_app(514) > [APP 851] Event: RESUME State: PAUSED
03-20 17:06:00.562+0900 I/CAPI_APPFW_APPLICATION(  851): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
03-20 17:06:00.562+0900 E/cluster-home(  851): homescreen.cpp: OnResume(233) >  app resume
03-20 17:06:00.583+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
03-20 17:06:00.583+0900 W/AUL_AMD (  629): amd_launch.c: __e17_status_handler(3328) > pid(8537) status(4)
03-20 17:06:00.583+0900 W/AUL     (  629): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.hardwarekeyeventex01(8537)
03-20 17:06:00.583+0900 W/AUL     (  629): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8537, appid: org.example.hardwarekeyeventex01, status: bg
03-20 17:06:00.593+0900 I/Tizen::System( 1243): (259) > Active app [com.samsun], current [org.exampl] 
03-20 17:06:00.593+0900 I/Tizen::Io( 1243): (729) > Entry not found
03-20 17:06:00.593+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 36
03-20 17:06:00.603+0900 I/APP_CORE( 8537): appcore-efl.c: __do_app(514) > [APP 8537] Event: PAUSE State: RUNNING
03-20 17:06:00.603+0900 I/CAPI_APPFW_APPLICATION( 8537): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
03-20 17:06:00.623+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 8537): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 19
03-20 17:06:00.623+0900 E/APP_CORE( 8537): appcore-efl.c: _capture_and_make_file(1619) > win[6000002] widget[720] height[1280]
03-20 17:06:00.623+0900 W/AUL_AMD (  629): amd_request.c: __request_handler(906) > __request_handler: 33
03-20 17:06:00.623+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=30718503
03-20 17:06:00.633+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
03-20 17:06:00.633+0900 I/Tizen::System( 1243): (157) > change brightness system value.
03-20 17:06:00.633+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=30718565
03-20 17:06:00.633+0900 E/cluster-view(  851): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
03-20 17:06:00.633+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
03-20 17:06:00.633+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
03-20 17:06:00.643+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
03-20 17:06:00.643+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
03-20 17:06:00.643+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: fg
03-20 17:06:00.653+0900 W/HOME_APPS(  851): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.calculator/shared/res/calculator.png], Loading state:[1]
03-20 17:06:00.653+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
03-20 17:06:00.653+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
03-20 17:06:00.653+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: live-com.samsung.browser, status: bg
03-20 17:06:00.693+0900 E/cluster-home(  851): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
03-20 17:06:00.703+0900 W/cluster-view(  851): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
03-20 17:06:00.713+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
03-20 17:06:00.713+0900 W/cluster-home(  851): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
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
03-20 17:06:14.366+0900 W/CRASH_MANAGER( 9941): worker.c: worker_job(1199) > 110960463616c145846117
