List<char> alphabeth = "abcdefghijklmnopqrstuvwxyzåäö".ToList();

string chiffer = "qrgurzyvtnbeqrgnepwxcajtsnfgonxynatrf";
List<int> chiffersiffror;

GenerateNumbers(chiffersiffror);

void GenerateNumbers(List<int> chiffersiffror) {
    foreach (char letter in chiffer)
    {
        foreach (char alpha in alphabeth)
        {
            if (letter == alpha)
            {
                chiffersiffror.Add(alphabeth.IndexOf(letter));
            }
        }
    }
    Console.WriteLine(chiffersiffror);
}