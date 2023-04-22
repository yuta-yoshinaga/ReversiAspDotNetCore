# ReversiAspDotNetCore
リバーシアルゴリズムをC#で実装

## Description
リバーシのアルゴリズムをC#で実装したプロジェクトです。
フロントエンドからクリックされたマスの座標を通知されると、そのマスに置けるか否か、置いた結果のマス状況などをレスポンスするようにサーバーサイドが実装されています。
マスの状況はセッションに保存されており、フロントエンドのGUI設定などはWeb Storageに保存されて、ゲーム開始時にフロントエンドからサーバーへ通知されます。

## Usage
### Install
```sh
git clone https://github.com/yuta-yoshinaga/reversiaspdotnetcore.git
cd reversiaspdotnetcore
```

### Deploy
[render live](https://reversiaspdotnetcore.onrender.com/)
[render dev](https://reversiaspdotnetcore-dev.onrender.com/)

## Future Releases
TensorFlowを使って、AIの更新がしたい。

## Contribution
1. Fork it
2. Create your feature branch
3. Commit your changes
4. Push to the branch
5. Create new Pull Request

## License
[MIT](LICENSE)