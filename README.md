# CustomInputBox

「CustomInputBox」は、タイトル・プロンプト・ボタンラベルを自由に設定できるカスタマイズ可能な入力ダイアログです。  
標準の 「InputBox」にはない柔軟なUI・複数ボタン対応を備えています。

---

## 主な特徴

- タイトル・プロンプト・初期入力値を自由に設定可能
- 左・中央・右の **3ボタンにそれぞれカスタムラベル**を設定可能
- 押されたボタンの判定も簡単（`DialogResult`拡張）
- アイコン画像の表示対応（任意）

---

## 対応言語

このプロジェクトは以下の **両方の言語で使用可能**です：

- 🟦 VB.NET
- 🟨 C#

どちらの言語でも同じように使用できるように設計されています。  
サンプルコード（`VB` / `C#`）も用意しており、**混在プロジェクトや移行作業にも対応可能**です。

---

## 使用方法

```vbnet
Dim inp As New CustomInputBox.CustomMsgForm("タイトル", "名前を入力してください", "はい", "いいえ", "キャンセル")
If inp.ShowDialog() = DialogResult.OK Then
    MessageBox.Show("入力された値：" & inp.InputText)
End If
```
<br>

```csharp
var inp = new CustomInputBox.CustomMsgForm("タイトル", "名前を入力してください", "はい", "いいえ", "キャンセル");
if (inp.ShowDialog() == DialogResult.OK)
{
    MessageBox.Show("入力された値：" + inp.InputText);
}
```
