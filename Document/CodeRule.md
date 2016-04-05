# コーディングルール

----

### **【パスカル型】**

+ **型名**
(class, struct, enum etc…)
+ **メソッド名**
+ **ファイル名**
+ **フォルダ名**

### *パスカル例*
~~~
class Player //クラス名
struct PlayerData //構造体名
enum SceneNumber //列挙体名
public int Move(){} //メソッド名
Player.cs //スクリプト名
Player.Prefab //プレハブ名
Player.png //画像名
Player //フォルダ名
~~~

----

### **【キャメル型】**

+ **ローカル変数名**
+ **メンバ変数**
(_で始まるキャメル型)
+ **プロパティ名**

### *キャメル例*
~~~
public void Update()
{
  GameObject playerBullet; //ローカル変数
}
private GameObject _playerBullet; //メンバ変数
public int isValue{ get; set; } //プロパティ
~~~

----

### **【スネーク型】**

+ **引数**
(小文字)
+ **定数**
(大文字)

### *スネーク例*
~~~
public void UpdateHighScore(int high_score){} //引数
private const int POINT = 10; //定数
~~~

----

### その都度、変更予定
