@echo off
cls
echo FFmpeg wird heruntergeladen...
curl -L --remote-name --url https://github.com/BtbN/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-gpl.zip
echo Fertig!
echo FFmpeg wird entpackt
tar -x -f ffmpeg-master-latest-win64-gpl.zip
echo Fertig!
pause
exit