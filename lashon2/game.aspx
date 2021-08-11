<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="game.aspx.cs" Inherits="lashon2.game" %>

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
    <div class="gameOptions">
        <a href="gizra.aspx">
            <div class="game">
                <pre style="text-decoration:none; color:black;">  מצא את הגזרה</pre>
                <img src="images/letters.jpg" />
            </div>
        </a>
        <a href="binyan.aspx">
            <div class="game">
                <pre style="text-decoration:none; color:black;">  מצא את הבניין</pre>
                <img src="images/letters2.jpg" />
            </div>
        </a>
        <a href="different.aspx">
            <div class="game">
                <pre style="text-decoration:none; color:black;">  מצא את השונה</pre>
                <img src="images/lashon1.jpg" />
            </div>
        </a>
    </div>

    </form>
</body>
</html>
