
[How To] Remove And Restore Nuget Packages - Reduce Solution Size On Disk

����������� ����� �� �� �������� ��������� ������ �� solution-� � ������ �� �������� ����������, �� �� �� ����� ���.

1. Enabling package restore during build

Tools -> Options -> Package Manager -> General

�������� Allow NuGet to download missing packages during build

2. ����� ����� ����� solution-a � Enable NuGet Package Restore

3. � ����� packages ��������� ������ ��� Microsoft.BCL ������� (��� ����� ������) � repositories.config ����� (�� ��� ������� ���� � �����)

Restore: �������� solution-a, ����� ����� ����� solution-� � Manage NuGet Packages for this solution... -> ��� ����� Restore, ����� �� ��������� ������ ����� NuGet Packages

http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages
