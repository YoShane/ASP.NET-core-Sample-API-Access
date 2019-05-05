# Sample API Access
<br>
<b>Provides a simple API access site example, API function will be saving data to Access database.</b>

<h3>Description of transformation process</h3>
> 1.  Install .net core dotnet hosting-bundle and .net core 2.2 SDK<br>
> 2.  Perform CMD as a job manager and attach the following 3 instructions in the sequence. (install https certs & Access database driver)<br>
<ul>
<li>dotnet dev-certs https –trust</li>
<li>@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"</li>
<li>choco install msaccess2010-redist-x64</li></ul><br>

> 3.  Do work hosing<br>
<ul>
<li>Using CMD cd to <b>Lab_A\Lab_A</b></li>
<li>enter <b>dotnet run (This is sample website)</b></li>
</ul><br>
<ul>
<li>Open a new CMD page and cd to <b>Lab_B\Lab_B</b></li>
<li>enter <b>dotnet run (This is sample API-recive POST)</b></li>
</ul><br>