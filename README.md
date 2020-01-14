# TextPrettifier
C# typography prettifier tool for web texts
– .NET Standard 2.0

[![NuGet](https://img.shields.io/nuget/dt/TextPrettifier.svg?style=flat-square)](https://www.nuget.org/packages/TextPrettifier)
[![NuGet](https://img.shields.io/nuget/v/TextPrettifier.svg?style=flat-square)](https://www.nuget.org/packages/TextPrettifier)

## NuGet
```
Install-Package TextPrettifier
```

## Sample

```
A long time ago, in a galaxy far,far away...
It is a period of civil war. Rebel
spaceships, striking from a hidden
base, have won their first victory
against the evil Galactic Empire.

Price: 128 credits
```

```
A&nbsp;long time&nbsp;ago, in a&nbsp;galaxy&nbsp;far, far&nbsp;away...
It is a&nbsp;period of&nbsp;civil&nbsp;war. Rebel
spaceships, striking from a&nbsp;hidden
base, have won&nbsp;their first victory
against the&nbsp;evil Galactic Empire.

Price: 128 credits
```

## Rules
### Double hyphen to dash
from:
```
--
```
to:
```
–
```


### Merge spaces
from:
```
Hello    world
```
to:
```
Hello world
```


### Space after comma
from:
```
Hello,world
```
to:
```
Hello, world
```


### Non-breaking space between short and long words
from:
```
striking from a hidden
```
to:
```
striking from a&nbsp;hidden
```



### Non-breaking space between number and following text
from:
```
Price: 128 credits
```
to:
```
Price 128&nbsp;credits
```



### Non-breaking space between long and short words
from:
```
Going on a bus
```
to:
```
Going&nbsp;on a&nbsp;bus
```


### Non-breaking space around dash
from:
```
Perpetuum Mobile — Myth
```
to:
```
Perpetuum Mobile&nbsp;—&nbsp;Myth
```
