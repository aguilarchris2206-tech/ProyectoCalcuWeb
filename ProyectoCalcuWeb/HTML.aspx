<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HTML.aspx.cs" Inherits="ProyectoCalcuWeb.HTML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora Avanzada</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #6a11cb 0%, #2575fc 100%);
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            margin: 0;
            padding: 20px;
        }
        
        .calculator-container {
            background-color: rgba(255, 255, 255, 0.95);
            border-radius: 20px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);
            padding: 25px;
            width: 100%;
            max-width: 400px;
        }
        
        h1 {
            text-align: center;
            color: #333;
            margin-bottom: 20px;
            font-weight: 600;
        }
        
        .display {
            background-color: #f8f9fa;
            border: 2px solid #e9ecef;
            border-radius: 10px;
            padding: 15px;
            margin-bottom: 20px;
            text-align: right;
            min-height: 60px;
            display: flex;
            align-items: center;
            justify-content: flex-end;
            font-size: 28px;
            font-weight: bold;
            color: #333;
            overflow: hidden;
            word-break: break-all;
        }
        
        .buttons-grid {
            display: grid;
            grid-template-columns: repeat(4, 1fr);
            gap: 12px;
        }
        
        .button {
            border: none;
            border-radius: 10px;
            padding: 15px 0;
            font-size: 18px;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.2s ease;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }
        
        .button:hover {
            transform: translateY(-2px);
            box-shadow: 0 6px 8px rgba(0, 0, 0, 0.15);
        }
        
        .button:active {
            transform: translateY(1px);
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }
        
        .number {
            background-color: #ffffff;
            color: #333;
            border: 1px solid #dee2e6;
            width: 23px;
        }
        
        .number:hover {
            background-color: #f8f9fa;
        }
        
        .operator {
            background-color: #007bff;
            color: white;
        }
        
        .operator:hover {
            background-color: #0069d9;
        }
        
        .equals {
            background-color: #28a745;
            color: white;
        }
        
        .equals:hover {
            background-color: #218838;
        }
        
        .clear {
            background-color: #dc3545;
            color: white;
        }
        
        .clear:hover {
            background-color: #c82333;
        }
        
        .function {
            background-color: #6c757d;
            color: white;
        }
        
        .function:hover {
            background-color: #5a6268;
        }
        
        .advanced-buttons {
            display: grid;
            grid-template-columns: repeat(4, 1fr);
            gap: 12px;
            margin-top: 15px;
        }
        
        .zero {
            grid-column: span 2;
        }
        
        .additional-controls {
            margin-top: 25px;
            padding-top: 20px;
            border-top: 1px solid #dee2e6;
        }
        
        .control-group {
            margin-bottom: 15px;
        }
        
        .control-group label {
            display: block;
            margin-bottom: 8px;
            font-weight: 500;
            color: #495057;
        }
        
        
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="calculator-container">
            <h1>Calculadora Avanzada</h1>
            
            <!-- Pantalla de resultados -->
            <div class="display">
                <asp:Label ID="lresultado" runat="server" Text="0"></asp:Label>
            </div>
            
            <!-- Botones de la calculadora -->
            <div class="buttons-grid">
                <!-- Fila 1: Botones avanzados -->
                <asp:Button ID="bclear" class="button clear" Text="C" runat="server"  OnClick="bclear_Click" />
                <asp:Button ID="bpower2" class="button function" Text="x²" runat="server" OnClick="bpower2_Click"  />
                <asp:Button ID="bpower3" class="button function" Text="x³" runat="server" OnClick="bpower3_Click"  />
                <asp:Button ID="bsqrt" class="button function" Text="√" runat="server" OnClick="bsqrt_Click"  />
                
                <!-- Fila 2: 7, 8, 9, / -->
                <asp:Button ID="b7" class="button number" Text="7" runat="server" OnClick="b7_Click"  />
                <asp:Button ID="b8" class="button number" Text="8" runat="server" OnClick="b8_Click" />
                <asp:Button ID="b9" class="button number" Text="9" runat="server" OnClick="b9_Click" />
                <asp:Button ID="bdivide" class="button operator" Text="/" runat="server" OnClick="bdivide_Click"  />
                
                <!-- Fila 3: 4, 5, 6, * -->
                <asp:Button ID="b4" class="button number" Text="4" runat="server" OnClick="b4_Click"  />
                <asp:Button ID="b5" class="button number" Text="5" runat="server" OnClick="b5_Click"  />
                <asp:Button ID="b6" class="button number" Text="6" runat="server" OnClick="b6_Click"  />
                <asp:Button ID="bmultiply" class="button operator" Text="*" runat="server" OnClick="bmultiply_Click"  />
                
                <!-- Fila 4: 1, 2, 3, - -->
                <asp:Button ID="b1" class="button number" Text="1" runat="server" OnClick="b1_Click"  />
                <asp:Button ID="b2" class="button number" Text="2" runat="server" OnClick="b2_Click"  />
                <asp:Button ID="b3" class="button number" Text="3" runat="server" OnClick="b3_Click"  />
                <asp:Button ID="bresta" class="button operator" Text="-" runat="server" OnClick="bresta_Click"  />
                
                <!-- Fila 5: 0, ., +, = -->
                <asp:Button ID="b0" class="button number zero" Text="0" runat="server" OnClick="b0_Click"  />
                <asp:Button ID="bdecimal" class="button number" Text="." runat="server" OnClick="bdecimal_Click"  />
                <asp:Button ID="bsuma" class="button operator" Text="+" runat="server" OnClick="bsuma_Click"  />
                <asp:Button ID="bresultado" class="button equals" Text="=" runat="server" OnClick="bresultado_Click"  />
                 <!-- Botones avanzados adicionales -->
                <asp:Button ID="Button1" class="button function" Text="n!" runat="server" OnClick="Button1_Click"  />
                <asp:Button ID="Button2" class="button function" Text="Fib" runat="server" OnClick="Button2_Click" />
            </div>
            
            <!-- Controles adicionales -->
            <div class="additional-controls">
            </div>
        </div>
    </form>
</body>
</html>