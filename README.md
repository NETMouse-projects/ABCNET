
# ABCNET
## Краткое описание
`ABCNET` - альтернатива модулю `PABCSystem` для всего `NET`. Ориентирована на русскоязычную аудиторию. Более подробно об `ABCNET` можно узнать в [презентации](https://github.com/NETMouse-projects/ABCNET/tree/master/NETMouse%20-%20.NET%20release/Presentations) (желательно просматривать через `Power Point`).

## Минимальные требования
`NET Framework 4.0`

# Организация проекта
- [Alvin Seville](https://github.com/Alvin-Seville) (руководитель проекта и основатель `NETMouse-projects`)
- [ProMix0](https://github.com/ProMix0) (главный разработчик)
- [egor2812](https://github.com/egor2812) (поддержка)

[Правила работы с Issue и Pull Requests для пользователей](https://github.com/NETMouse-projects/ABCNET/blob/master/CONTRIBUTING.md)

# Цель проекта
Обеспечить пользователей `PascalABC.NET` `PABCSystem`-подобным функционалом за пределами данного языка. Но, в то же время, не предоставлять множество обёрток для работы с типами `NET`, а стимулировать обучающихся изучать данную платформу.

Выучите одну библиотеку один раз и используйте её на любом `NET`-языке!

# Принципы проекта
- Оптимизация важна
- Простота функционала
- Избегание использования специфических возможностей компиляторов

# Варианты использования
## PascalABC.NET
### Через скачивание архива напрямую
Скачайте архив `ABCNET.rar` и разархивируйте его в папку с программой (не в директорию `PascalABC.NET` из `Program Files (x86)`).

### Через пакетный менеджер `NuGet` в режиме проекта
![PascalABC.NET - NuGet package installation](https://sun9-29.userapi.com/c204828/v204828716/488d3/eFcKpAIwcP8.jpg)
Установите `NuGet-пакет` [`NETMouseProjectsOrganization.ABCNET`](https://www.nuget.org/packages/NETMouseProjectsOrganization.ABCNET/0.5.0.3) через `Подключённые сборки`->`Добавить сборку`->`NuGet`.

### Рекомендуемый шаблон кода
Используйте следующий шаблон кода для написания программы через `ABCNET` в [`PascalABC.NET`](https://drive.google.com/open?id=1eHzHpHw7SYTCwefaxYPr4QbsB1bf6M41):
```pascal
{$reference ABCNET.dll} // Уберите данную строку, если используйте ABCNET в режиме проекта и подключили её как NuGet-пакет.
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  // code here
end.
```

## Visual Studio 2019
### Через скачивание архива напрямую
Скачайте архив и разархивируйте его в любую папку. Подключите библиотеку через `<project>`->`Add`->`Reference`. Используйте следующий шаблон кода для написания программы через `ABCNET` на `C#`:

### Через пакетный менеджер `NuGet`
![Visual Studio - NuGet package installation](https://sun9-23.userapi.com/c858232/v858232025/15cb70/z-NsdL6lZTk.jpg)
Установите `NuGet-пакет` [`NETMouseProjectsOrganization.ABCNET`](https://www.nuget.org/packages/NETMouseProjectsOrganization.ABCNET/0.5.0.3) через `<project>`->`Manage NuGet Packages`->`Browse`.

### Рекомендуемый шаблон кода
Используйте следующий шаблон кода для написания программы через `ABCNET` на `C#`:
```Csharp
using ABCNET.Utils;
using ABCNET.Extensions;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // code here
        }
    }
}
```

# Порты
- [`ABCPy`](https://github.com/NETMouse-projects/ABCPy) (для `Python`)
- [`ABCJava`](https://github.com/NETMouse-projects/ABCJava) (для `Java`)
- [`ABCCPlusPlus`](https://github.com/NETMouse-projects/ABCCPlusPlus) (для `C++`)

# Для разработчиков
## Жизненный цикл ABCNET
Любая версия должна содержать не более 25 `Issue`.
- Первые 5 `Issue` затрагивают `API` библиотеки (по их количеству ведётся версионирование).
- Вторые 5 `Issue` (необязательные) затрагивают `API` библиотеки.
- Третьи 5 `Issue` (необязательные) затрагивают исправления `API` библиотеки (`bug-small` и `bug-critical`).
- Четвёртые 5 `Issue` (необязательные) затрагивают примеры для `API` библиотеки.
- Пятые 5 `Issue` (необязательные) затрагивают внутренние изменения, которые не видны пользователям.

Формат версии: `x.y.z`, где:
- `x` - major-версия, принимает любое неотрицательное значение.
- `y` - minor-версия, принимает значение 0 и 5.
- `z` - количество закрытых Issue, касающихся `API` библиотеки.

Каждая major-версия закрывает в сумме ровно 100 (при учёте необязательных) `Issue` по `API`-библиотеки и состоит из двух minor-версий. Каждая сборка minor-версии закрывает в сумме ровно 5 `Issue` по `API`-библиотеки.

# Инструменты разработки
## Обязательные инструменты
- `IDE` - [`Visual Studio 2019`](https://visualstudio.microsoft.com/vs/), [`Repl.it`](https://repl.it/)
- Пллагины для [`Visual Studio 2019`](https://visualstudio.microsoft.com/vs/) - [`File Nesting`](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.FileNesting)
- Декомпилятор - [`dotPeek`](https://www.jetbrains.com/decompiler/)
- `VCS` - [`Git`](https://git-scm.com/download) с [`Git Bash`](https://git-scm.com/download)
- Язык автоматизации - [`Bash`](https://www.tldp.org/LDP/Bash-Beginners-Guide/html/)
- Фреймворки - `NET Framework 4.0`, [`NUnit`](https://nunit.org/)

## Рекомендуемые инструменты
- `IDE` - [`myCompiler`](https://www.mycompiler.io/)
- Пллагины для [`Visual Studio 2019`](https://visualstudio.microsoft.com/vs/) - [`Roslynator 2019`](https://marketplace.visualstudio.com/items?itemName=josefpihrt.Roslynator2019), [`CodeMaid`](https://marketplace.visualstudio.com/items?itemName=SteveCadwallader.CodeMaid), [`Markdown Editor`](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor), [`File Icons`](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.FileIcons), [`Trailing Whitespace Visualizer`](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.TrailingWhitespaceVisualizer)

----
Если Вы не знакомы с `GitHub`, но Вам есть что сообщить или предложить нам, пожалуйста, воспользуйтесь [`данной формой`](https://forms.yandex.ru/u/5e1de81b0733df0bb13408e3/). 

[![Discord](https://user-images.githubusercontent.com/42812113/76321598-4c9aa680-62f3-11ea-9c4c-10b70b0a17da.png)](https://discord.gg/j8Xf6Me)
