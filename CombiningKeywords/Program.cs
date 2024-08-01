
object input =  10;

string result = input switch
{
    int value when value is > 0 => "Positive Number ",
    int value when value is < 0 => "Negative Number",

    string str when str is { Length : 0} or { Length : 1} => "Empty or single character",
    string str when str is { Length : > 1 } => "String with more than one character",
    not null => "Some other not null type",
    _ => "Null Value",

};
Console.WriteLine(result);