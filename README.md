# TextPrettifier
C# typography prettifier tool for web texts, HTML support

– .NET Standard 2.0

[![NuGet](https://img.shields.io/nuget/dt/TextPrettifier.svg?style=flat-square)](https://www.nuget.org/packages/TextPrettifier)
[![NuGet](https://img.shields.io/nuget/v/TextPrettifier.svg?style=flat-square)](https://www.nuget.org/packages/TextPrettifier)

## NuGet
```
Install-Package TextPrettifier
```

## Sample
```cs
TextPrettifier prettifier = new TextPrettifier();

Console.WriteLine(prettifier.PrettifyForWeb(@"
    A long time ago, in a galaxy far,far away...
    It is a period of civil war. Rebel
    spaceships, <span title='this is a popular quote' style='font-weight: bold'>striking from a hidden
    base</span>, have won their first victory
    against the evil Galactic Empire.
    
    Price: 128 credits"));
```


```
A&nbsp;long time&nbsp;ago, in a&nbsp;galaxy&nbsp;far, far&nbsp;away...
It is a&nbsp;period of&nbsp;civil&nbsp;war. Rebel
spaceships, <span title='this is a popular quote' style='font-weight: bold'>striking from a&nbsp;hidden
base</span>, have won&nbsp;their first victory
against the&nbsp;evil Galactic Empire.

Price: 128&nbsp;credits
```

## Rules
#### Double hyphen to dash
```
--
```
```
–
```


#### Merge spaces
```
Hello    world
```
```
Hello world
```


#### Space after comma
```
Hello,world
```
```
Hello, world
```


#### Non-breaking space between short and long words
```
striking from a hidden
```
```
striking from a&nbsp;hidden
```



#### Non-breaking space between number and following text
```
Price: 128 credits
```
```
Price: 128&nbsp;credits
```



#### Non-breaking space between long and short words
```
Going on a bus
```
```
Going&nbsp;on a&nbsp;bus
```


#### Non-breaking space around dash
```
Perpetuum Mobile — Myth
```
```
Perpetuum Mobile&nbsp;—&nbsp;Myth
```

#### Only text between > and < is prettified (outside of HTML tags)
```
striking from a hidden <span style=\"width: 3px\" title=\"not a big deal\">striking from a hidden</span>
```
```
striking from a&nbsp;hidden <span style=\"width: 3px\" title=\"not a big deal\">striking from a&nbsp;hidden</span>
```

# Change log
- 2020.1.1
  - handle HTML tags correctly
  - Test
