Console.WriteLine("Escolha:\n" +
    "1 - Hello World\n" +
    "2 - Calculadora\n" +
    "3 - Par ou Impar");
string escolha = Console.ReadLine();
switch (escolha)
{
    case "1":
        Console.WriteLine("        ,--,\r\n      ,--.'|              ,--,      ,--,                            .---.                        ,--,\r\n   ,--,  | :            ,--.'|    ,--.'|                           /. ./|                      ,--.'|          ,---,\r\n,---.'|  : '            |  | :    |  | :       ,---.           .--'.  ' ;    ,---.     __  ,-. |  | :        ,---.'|\r\n|   | : _' |            :  : '    :  : '      '   ,'\\         /__./ \\ : |   '   ,'\\  ,' ,'/ /| :  : '        |   | :\r\n:   : |.'  |    ,---.   |  ' |    |  ' |     /   /   |    .--'.  '   \\' .  /   /   | '  | |' | |  ' |        |   | |\r\n|   ' '  ; :   /     \\  '  | |    '  | |    .   ; ,. :   /___/ \\ |    ' ' .   ; ,. : |  |   ,' '  | |      ,--.__| |\r\n'   |  .'. |  /    /  | |  | :    |  | :    '   | |: :   ;   \\  \\;      : '   | |: : '  :  /   |  | :     /   ,'   |\r\n|   | :  | ' .    ' / | '  : |__  '  : |__  '   | .; :    \\   ;  `      | '   | .; : |  | '    '  : |__  .   '  /  |\r\n'   : |  : ; '   ;   /| |  | '.'| |  | '.'| |   :    |     .   \\    .\\  ; |   :    | ;  : |    |  | '.'| '   ; |:  |\r\n|   | '  ,/  '   |  / | ;  :    ; ;  :    ;  \\   \\  /       \\   \\   ' \\ |  \\   \\  /  |  , ;    ;  :    ; |   | '/  '\r\n;   : ;--'   |   :    | |  ,   /  |  ,   /    `----'         :   '  |--\"    `----'    ---'     |  ,   /  |   :    :|\r\n|   ,/        \\   \\  /   ---`-'    ---`-'                     \\   \\ ;                           ---`-'    \\   \\  /\r\n'---'          `----'                                          '---\"                                       `----'\r\n\r\n");
        break;

    case "2":
       Console.Write("Primeiro Número:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo Número:");
        int num2 = Convert.ToInt32(Console.ReadLine()); 
        
        Console.WriteLine("Escolha:" +
            "1 - Soma\n" +
            "2 - Subtração\n" +
            "3 - Multiplicação\n" +
            "4 - Divisão");
        string op = Console.ReadLine();

        Console.Write("Resultado:");

        switch (op)
        {
            case "1":
                Console.WriteLine(num1 + num2);
                break;
            case "2":
                Console.WriteLine(num1 - num2);
                break;
            case "3":
                Console.WriteLine(num1 * num2);
                break;
            case "4":
                Console.WriteLine(num1 / num2);
                break;
        }
        break;

    case "3":
        Console.Write("Escreva o Número:");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if (num % 2 == 0)
        {
            Console.WriteLine("Par");

        }else
        {
            Console.WriteLine("Impar");
        }
        break;
}
