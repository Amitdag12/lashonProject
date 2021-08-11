<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="different.aspx.cs" Inherits="lashon2.different" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="styles/StyleSheet.css"/>

</head>
<body>
    <form id="form1" runat="server">
      <div>  
        <h1>ברוכים הבאים למשחק הגזרות</h1>
    </div>
    <div class="navBar">
        <ul>
            <li class="active"><a href="game.aspx">המשחק</a></li>
            <li><a href="rules.aspx">הוראות</a></li>
            <li><a href="info.aspx">מידע</a></li>
        </ul>
    </div>
    <div class="question">
        <h1><asp:Label ID="LblSentence" runat="server" Text="Label"></asp:Label></h1>
        
        <asp:TextBox ID="TxtAnswer" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="בדוק" CssClass="submit" OnClick="btnCheck" />
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="rule">
        <p>מצא את השונה:<br />מולך יופיעו ארבעה משפטים,<br /> עליך לרשום את מספרו של המשפט יוצא הדופן (1-4)<br /> שימו לב שאין רווח לפני או אחרי התשובה בכדי שהמערכת תקלוט אותה בצורה נכונה</p>
    </div>
        <asp:Label ID="LblRepeat" runat="server" Text="0" Visible="false"></asp:Label>
        <asp:Label ID="LblUsedQuestion" runat="server" Text="1" Visible="false"></asp:Label>
        <asp:Label ID="LblScore" runat="server" Text="0" Visible="false"></asp:Label>
    </form>
</body>
</html>
