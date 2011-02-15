import OnyxJS;

//available functions
//MockUp.test() -- prints a test message
//MockUp.printl(s) -- prints the variable on a line and imediatly gose to the next line
//MockUp.print(s) -- prints a variable
//MockUp.wait_key() -- vaits 4 user input

var string="string test";
MockUp.printl(string);

MockUp.wait_key();
MockUp.test();//this procedure is located in MockUp.cs

var string=function(){return "lamda";};//
MockUp.printl(string());//inline don't work 

MockUp.wait_key();

function z(){return "ze Z";}

MockUp.printl(z());