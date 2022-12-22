// ВИД4
string vesion4(int count, string Text)
{
int i = 0;
string result = string.Empty;
for (int i = 0; i < count;i++)
{
result = (result + Text);
}
return result;
}
string res = vesion4(4, "hello");
Console.WriteLine(res);



