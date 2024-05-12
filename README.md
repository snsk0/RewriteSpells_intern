# RewriteSpells(Only Source Code)
## ゲーム概要
ジャンルは3DのローグライクRPGです。プレイヤーは敵を倒した時に手に入る魔法や、そのカスタマイズアイテムを使って独自の魔法を構築しながら戦います。
ゲームクリエイターズ甲子園様提出作品なため、詳細は以下リンクよりお確かめください。
> https://gameparade.creators-guild.com/works/406
> 

## 制作概要
ゲームエンジン: Unity</br>
使用言語: C#</br>
使用ライブラリ: UniRx, UniTask, etc...</br>
制作人数: プログラマ4名</br>
製作期間: 約3カ月</br>

## ライブラリ概要
[UniRx](https://assetstore.unity.com/packages/tools/integration/unirx-reactive-extensions-for-unity-17276?locale=ja-JP)はUnityのためのReactictive Extensionです。</br>
[UniTask](https://github.com/Cysharp/UniTask)はUnityに最適化された非同期処理を提供します。</br>
※詳細はリンク先より参照いただければ幸いです。</br>

## コード概要
以下ファイル内のソースコードがリポジトリオーナーが作成した主なソースコードです。</br>
・魔法関連コード
> RewriteSpells_intern/CM_Scripts/Magic
> 
・UIのPresenter(MV(R)PパターンにおけるPresenter)
> RewriteSpells_intern/CM_Scripts/UI/Presenter
>
・アイテムデータやデータ管理
> RewriteSpells_intern/CM_Scripts/Inventories
> 

### 魔法システム
プレイヤーに幅広いビルドを提供するため、魔法のカスタマイズはパラメーター(威力や消費魔力等)のみならず、追加の魔法が、それぞれの魔法の任意のタイミングで発生する(爆発や弾の拡散)ようになっています。
クラス設計上、ノードのような構造をしているため、ただ火の弾を射出する魔法が、着弾点で爆発を発生させたり、弾が分裂したりするカスタマイズを施せるようになっています。また、射出の際に玉の数を拡散させることで増やすカスタマイズなど、様々なものを作成することに成功しています。

### クラス設計
本実装ではアイテムデータのタスクが浮いている状態での開発になったため、UIが先んじて実装されていました。そのため、データは後から実装することとなりました。UI実装者も担当者が違っていたたため、UniRxを利用し、MV(R)Pパターンを適用することによって、データとUIの結合度をできるだけ下げ、
Presenter側にコードを追加することによってこれを解決できるようにしました。
