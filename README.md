# Progress_Test (.NET MAUI)

A cross‑platform .NET MAUI app targeting Android, iOS, MacCatalyst, and Windows (net9.0). The main screen showcases Vincent van Gogh’s profile with an expandable biography and a simple masonry‑style gallery of artworks.

## Overview

- Built with .NET 9 and the MAUI single‑project model
- Targets: `net9.0-android`, `net9.0-ios`, `net9.0-maccatalyst`, `net9.0-windows10.0.19041.0`
- UI: expandable “Read More/Read Less” biography, two‑column artwork grid
- Data: seeded in a view model and bound via `BindableLayout`

## Prerequisites

- Windows 10/11 with Visual Studio 2022 (Community or higher) and the **.NET MAUI** workload
- .NET SDK 9.0 (`dotnet --version` should show 9.x)
- Android SDK and an emulator/device for Android builds
- For iOS/MacCatalyst: a Mac with Xcode and MAUI workloads (for build/run)
- Install MAUI workload if missing:

```bash
dotnet workload install maui
```

## Getting Started

```bash
# Clone the repository
# (adjust path as needed)
cd "d:/Mobile Development/Progress_Test/Progress_Test"

# Restore and build
dotnet restore
dotnet build
```

## Run

- Windows:

```bash
dotnet run -f net9.0-windows10.0.19041.0
```

- Android (emulator or connected device):

```bash
dotnet build -t:Run -f net9.0-android
```

- iOS / MacCatalyst (on macOS):

```bash
# On a Mac with Xcode and MAUI workloads
dotnet build -t:Run -f net9.0-ios
# or
dotnet build -t:Run -f net9.0-maccatalyst
```

## Project Structure

- `MainPage.xaml` — Defines the main UI with profile header and artworks grid
- `MainPage.xaml.cs` — Handles the “Read More” toggle via tap (`MainPage.xaml.cs:12`)
- `ViewModels/ProfileViewModel.cs` — Supplies UI data and expansion state
  - `Biography` and `IsBioExpanded` (`ViewModels/ProfileViewModel.cs:13`, `ViewModels/ProfileViewModel.cs:17`)
  - Two artwork collections for the masonry effect (`ViewModels/ProfileViewModel.cs:10`, `ViewModels/ProfileViewModel.cs:11`)
- `Models/Artwork.cs` — Artwork model (`Models/Artwork.cs:1`)
- `Resources/Images/*` — Image assets
- `Progress_Test.csproj` — Target frameworks and MAUI assets (`Progress_Test.csproj:4`, `Progress_Test.csproj:51`)

## Notable UI Bindings

- Biography label binds truncation/max lines to expansion state (`MainPage.xaml:32`–`MainPage.xaml:33`)
- “Read More” label toggles expansion via tap handler (`MainPage.xaml.cs:12`–`MainPage.xaml.cs:18`)
- Artwork grids use `BindableLayout.ItemsSource` for two columns (`MainPage.xaml:60`, `MainPage.xaml:74`)

## Troubleshooting

- Missing workloads: run `dotnet workload list` and install MAUI if absent
- Android build errors: ensure Android SDK/emulator; update VS + workloads
- Images not showing: verify assets exist under `Resources/Images` and are included in the project (`Progress_Test.csproj:51`–`Progress_Test.csproj:54`)
- Windows run issues: confirm Windows target `net9.0-windows10.0.19041.0` and supported platform versions (`Progress_Test.csproj:39`–`Progress_Test.csproj:40`)

## License

This project’s licensing is not specified. Add a license if needed.
