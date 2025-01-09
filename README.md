# そっくりさん判定アプリ
## 基本仕様
- 使用言語： C#
- GUIライブラリ： WindowsForms
- 使用API： OpenCV
## 使用方法
何故かダウンロードしようとするとウイルス対策ソフトによってブロックされる（おそらくexeファイルの誤検出）ため、ここからの指示のダウンロード、インストール、起動は全て**自己責任**でお願いします。
1. CODE→Download ZIPからダウンロードし、ウイルス対策ソフトにブロックされたら許可してダウンロードする。
2. ダウンロードして解凍したら　bin→Release→net8.0-windowsと移動する。
3. この時点でWindows Desktop Runtimeがインストールされていないとアプリが起動しないので、検索してインストールするか、起動時にインストールを促されてWeb上のインストールページに飛ばされるのでインストールしてください。
4. Look-alike_Judging.exeを起動する。起動の際にまたウイルス対策ソフトにブロックされると思うので警告を無視して実行する。
5. なるべく顔の大きさ、明暗が合った顔画像を用意する。
6. 用意した顔画像を、画像１画像２の場所に追加ボタンを押して追加するか、ドラッグ＆ドロップで追加する。
7. 判定開始ボタンを押すと、判定が開始され、そっくりさん度が表示される。
8. 右下に書いてある目安を見てどのくらいそっくりさんなのか判断する。（あくまで目安です）

### ライセンス
このプロジェクトはOpenCvSharpとOpenCVを使用しており、MIT LicenseとApache License 2.0でライセンスされています。詳細は LICENSE ファイルを参照してください。

This project uses OpenCvSharp and OpenCV, which is licensed under the MIT License and Apache License 2.0. See LICENSE file for more details.

OpenCvSharp
https://github.com/shimat/opencvsharp.git

OpenCV
https://github.com/opencv/opencv.git

以下のファイルをリソースとして使用しています。
https://github.com/opencv/opencv/blob/master/data/haarcascades/haarcascade_frontalface_default.xml
