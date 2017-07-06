Public Class Form1
    ''' <summary>
    ''' 定義一個自訂借錢動作的委派(想像成是定義一個介面，規定參數及回傳型態就對了)
    ''' </summary>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Delegate Function CustomAction(ByVal amount As String) As String
    ''' <summary>
    ''' 產生委派的參考
    ''' </summary>
    ''' <remarks></remarks>
    Private customAct_func As CustomAction
    ''' <summary>
    ''' 正妹借錢來
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGirl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGirl.Click
        '直接委派 LendToGirl 這個 Function 做事,逗號後面的參數則是 LendToGirl 這個 Function 所需要的引數
        'Invoke(New CustomAction(AddressOf LendToGirl), "20萬")

        '將要做事的 Function 丟入變數後，再傳到某個 Function 去開工
        customAct_func = AddressOf LendToGirl '把某個 Function 丟進 customAct_func 變數中
        LendAction("30萬", customAct_func) '這樣就可以把 Function 當成引數傳到其他 Function 中
    End Sub
    ''' <summary>
    ''' 死黨來借錢
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFriend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFriend.Click
        customAct_func = AddressOf LendToFriend
        LendAction("100", customAct_func)
        'Invoke(New CustomAction(AddressOf LendToFriend), "100")
    End Sub
    ''' <summary>
    ''' 魯蛇來借錢
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLoser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoser.Click
        customAct_func = AddressOf LendToLoser
        LendAction("10", customAct_func)
        'Invoke(New CustomAction(AddressOf LendToLoser), "10")
    End Sub

    ''' <summary>
    ''' 借錢動作
    ''' </summary>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LendAction(ByVal amount As String, ByVal customAct_func As CustomAction)
        txtresult.Text = String.Empty
        Dim finalAmount As String = ""
        '我們不需要知道這個customAct_func到底是什麼
        '反正他跑完會回傳一個我們要的東西就對了
        '在這裡回傳的就是最終借出金額
        finalAmount = customAct_func(amount)
        Debug.Print("finalAmount:" & finalAmount)
        Dim commonRes As String = 0
        If Not String.IsNullOrEmpty(finalAmount) Then
            commonRes = String.Format("借出{0}元", finalAmount)
        Else
            commonRes = "掉頭就走"
        End If
        txtresult.Text += commonRes
        Return Nothing
    End Function


    ''' <summary>
    ''' 借錢給正妹的自訂動作
    ''' </summary>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LendToGirl(ByVal amount As String) As String
        Dim res As String = ("真的只要借{0}元嗎，我可以借你{1}元!!" + Environment.NewLine)
        Dim finalAmount As String = "五百萬"
        txtresult.Text = String.Format(res, amount, finalAmount)
        Return finalAmount
    End Function


    ''' <summary>
    ''' 借錢給死檔的自訂動作
    ''' </summary>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LendToFriend(ByVal amount As String) As String
        Dim res As String = "幹...掏出{0}元" + Environment.NewLine
        txtresult.Text = String.Format(res, amount)
        Return amount
    End Function

    ''' <summary>
    ''' 借錢給魯蛇的自訂動作
    ''' </summary>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LendToLoser(ByVal amount As String) As String
        Return String.Empty
    End Function
End Class
