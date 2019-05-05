# Sample API Access

<h3>Description of transformation process</h3>
<h4>> 1.  Install .net core dotnet hosting-bundle and .net core 2.2 SDK</h4><br>
<h4>> 2.  Perform CMD as a job manager and attach the following three instructions in the sequence.<br> (install https certs & Access database driver)</h4><br><br>
<ul>
<li>dotnet dev-certs https –trust</li>
<li>@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"</li>
<li>choco install msaccess2010-redist-x64</li></ul><br>

<h4>> 3.  Do work hosing</h4><br>
<ul>
<li>Using CMD cd to <b>Lab_A\Lab_A</b></li>
<li>enter <b>dotnet run (This is sample website)</b></li>
</ul><br>
<ul>
<li>Open a new CMD page and cd to <b>Lab_B\Lab_B</b></li>
<li>enter <b>dotnet run (This is sample API-recive POST)</b></li>
</ul><br>