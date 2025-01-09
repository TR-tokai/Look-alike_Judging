# そっくりさん判定アプリ
## 基本仕様
- 使用言語： C#
- GUIライブラリ： WindowsForms
- 使用API： OpenCV
## 使用方法
1. なるべく顔の大きさ、明暗が合った顔画像を用意する。
2. 用意した顔画像を、画像１画像２の場所に追加ボタンを押して追加するか、ドラッグ＆ドロップで追加する。
3. 判定開始ボタンを押すと、判定が開始され、そっくりさん度が表示される。
5. 右下に書いてある目安を見てどのくらいそっくりさんなのか判断する。（あくまで目安です）

### ライセンス
このプロジェクトはOpenCvSharpとOpenCVを使用しており、MIT LicenseとApache License 2.0でライセンスされています。詳細は LICENSE ファイルを参照してください．

This project uses OpenCvSharp and OpenCV, which is licensed under the MIT License and Apache License 2.0. See LICENSE file for more details.

OpenCvSharp
https://github.com/shimat/opencvsharp.git

OpenCV
https://github.com/opencv/opencv.git

以下のファイルをリソースとして使用しています。
https://github.com/opencv/opencv/blob/master/data/haarcascades/haarcascade_frontalface_default.xml
