<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="info.aspx.cs" Inherits="lashon2.info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title></title>
    
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="styles/StyleSheet.css"/>


</head>
<body>
    <form id="form1" runat="server">
        
   <div class="heading">
        <h1>ברוכים הבאים למשחק הגזרות</h1>
    </div>
    <div class="navBar">
        <ul>
            <li><a href="game.aspx">המשחק</a></li>
            <li><a href="rules.aspx">הוראות</a></li>
            <li class="active"><a href="info.aspx">מידע</a></li>
        </ul>
    </div>
    <div class="rules">
        <div class="rule">
            <p>גזרת השלמים:<br />  גזרה שבה שלוש אותיות שורש נשמעות ונכתבות בכל הנטיות.<br /> מרבית הפעלים בשפה העברית נוטים לפי גזרת השלמים.<br />דוגמא: השתלם. </p>
        </div>
        <div class="rule">
            <p>גזרת המרובעים:<br />גזרה הכוללת את כל הפעלים בעלי 4 אותיות שורש.<br /> גזרה זו תופיע רק בבניינים : פיעל, פועל והתפעל, ובכל זאת לא יופיע בה דגש תבניתי.<br />דוגמאות: צלצל, צחקק, אבטח.</p>
        </div>
        <div class="rule">
            <p>גזרת נלי/ה:<br /> אחת מגזרות הנחים של הפועל כאשר לה"פ של השורש הוא יו"ד/ה"א שאינן נשמעות.<br /> דוגמאות: בנה, ראה, קנה.</p>
        </div>
        <div class="rule">
            <p>גזרת חפ"נ:<br /> גזרה בה פ"א הפועל היא האות נו"ן והיא חסרה בחלק מהנטייה.<br /> בגזרה זו קיימת נפילה של פה"פ נו"ן בבניינים נפעל, הֻפְעַל והפעיל.<br /> דוגמאות: נסע, הוכר, הגיע.</p>
        </div>
        <div class="rule">
            <p>גזרת נל"א:<br />  גזרת נחי לה"פ אלף גזרה בה לה"פ היא האות א', והיא נחה בנטייה.<br /> גזרת נל"א נוטה לפי גזרת השלמים.<br /> דוגמאות: שנא, מדוכא, מצא.</p>
        </div>
    </div>


    </form>
</body>
</html>
