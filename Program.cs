// See https://aka.ms/new-console-template for more information
Console.Clear();
string[] ourArray = {"hello", "hell", "cat", "as", "at"};
int arrLength = ourArray.Length; 
int y = 0;
string[] arrConsistOfThreeLettersWorld = new string[arrLength];


for(int i = 0; i<arrLength; i++)
   if(ourArray[i].Length<=3) {
      arrConsistOfThreeLettersWorld[y] = ourArray[i];
      y++;
   }

ourArray = new string[y+1];
for(int i = 0; i<y+1; i++) ourArray[i] = arrConsistOfThreeLettersWorld[i];
string result = "[ "+string.Join(" ", ourArray)+"]";
Console.Write(result);
   