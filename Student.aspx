<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Student.aspx.cs" Inherits="Student" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        @font-face {
            font-family: Poppins;
            src: url(Poppins-Regular.ttf);
        }
        
        * {
            padding: 0;
            box-sizing: border-box;
            font-family: Poppins;
            margin-left: 0;
            margin-right: 0;
            margin-top: 0;
        }

        body {
            background-color: lightblue;
            justify-content: center;
            align-items: center;
        }

        hr {
            border-radius: 50%;
            margin-bottom: 20px;
            color: black;
            height: 1px;
            width: 100%;
        }

        .btn {
            text-decoration: none;
            padding: 10px 30px;
            text-align: center;
            border-radius: 30px;
            font-weight: bolder;
            border: 2px solid white;
            color: white;
            background-color: gray;
            transition: 0.5s;
            width: 100%;
        }

        .btn:hover {
            background-color: lightblue ;
            letter-spacing: 1px;
        }

        body .flex {
            width: 100%;
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
        }

        body form {
            margin-top: 20px;
            width: 400px;
            
        }

        form .shad {
            padding: 20px;
            box-shadow: 0 0 20px gray;
            border-radius: 10px;
        }

        h1 {
            text-align: center;
            padding: 20px;
            font-size: 2.5em;
            letter-spacing: 2px;
        }

        form div h1 {
            text-align: center;
            padding: 10px;
            font-size: 2em;
        }

        form div input {
            border-radius: 4px;
            line-height: 2rem;
            font-size: 1rem;
            color: black;
            width: 366px;
            border: 1px solid gray;
            outline-color: white;
            padding: 5px;
        }

        .dis {
            display: flex;
            justify-content: space-between;
            padding: 10px 0;
            width: 100%;
        }

        .check {
            display: flex;
            flex-direction: row;
            text-align: center;
            justify-content: center;
            align-items: center;
            line-height: 1em;
        }

        .gray {
            color: rgb(89, 89, 89);
            cursor: pointer;
            text-decoration: none;
            transition: 0.5s;
        }

        .gray:hover {
            letter-spacing: 0.5px;
            color: rgb(63, 63, 63);
        }


    </style>
    <title>Document</title>
</head>
<body>
    <h1>WELCOME TO STUDENTS PORTAL!</h1>
    <hr>
    <div class="flex">
        <form id="form1" runat="server">
        <div class="flex shad">
            <h1>Log in</h1>
            <hr>
            &nbsp;Email:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Pass:&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br>
            &nbsp;<br>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="111px" />
        </div>
        </form>
        
        </div>
    </form>
</body>
</html>