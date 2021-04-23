# V1C8
Модуль для работы с 1С8.3 через COMConnections.
[![MIT License](https://img.shields.io/badge/license-MIT-red.svg)](https://github.com/sabatex/V1C8/blob/master/LICENSE.TXT)
[![NuGet Badge](https://buildstats.info/nuget/sabatex.V1C8)](https://www.nuget.org/packages/sabatex.V1C8/)

    <pre>
        Install
        Package Manager:
            PM>Install-Package sabatex.V1C8 -Version 5.0.1
        Command line:
            >dotnet add package sabatex.V1C8 --version 5.0.1
        Project file *.csproj:
            &ltPackageReference Include="sabatex.V1C8" Version="5.0.1"/&gt
    
    </pre>

    <p>
        Пример использования:
    </p>
     <pre>
        // создаём соединение
        using (var globalContext = COMObject1C8.CreateConnection("ConnectionString1C8")
        {
            // получаем документ
            var doc = globalContext.GetProperty&ltICOMObject1C8&gt("Documents").GetProperty&ltICOMObject1C8&gt("РасходнаяНакладная").Method&ltICOMObject1C8&gt("FindByNumber", "0000001", new DateTime(2021,01,01));


        }
    </pre>
