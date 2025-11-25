🎨 Van Gogh Gallery App (.NET MAUI)

A cross-platform mobile application developed with .NET 9.0 MAUI that showcases a responsive, interactive profile and art gallery for Vincent van Gogh.

✨ Features

This application implements advanced UI techniques and meets specific layout requirements:

1. 👤 Floating Profile Interface
   - Rounded Profile Picture: Implemented a perfect circle profile image using Border stroke shaping.
   - Floating Effect: The profile picture sits on the boundary of the background and the content card using Grid overlapping and negative margins.
   - Status: ✅ Requirement Fulfilled.

2. 📖 Interactive Biography
   - Expandable Text: Features a "Read More" / "Read Less" toggle.
   - Tail Truncation: Automatically truncates text with ellipses (...) when collapsed and wraps fully when expanded.
   - Implementation: Custom MVVM logic (boolean triggers) without external dependencies.
   - Status: ✅ Requirement Fulfilled.

3. 📊 Responsive Stats Grid
   - Equal Width Layout: Uses a Grid with `ColumnDefinitions="*,*,*,*"` to ensure the four statistic columns (Record, Average, General, Items) share equal width on any screen size.
   - No Hardcoded Margins: Spacing is handled dynamically by the Grid structure.
   - Status: ✅ Requirement Fulfilled.

4. 🖼️ Masonry Art Gallery
   - Staggered Layout: Implemented a Pinterest-style "Masonry" layout where images of different heights (Portrait vs. Landscape) fit perfectly without gaps.
   - Structure: Utilized a 2-Column Grid with independent `VerticalStackLayout`s inside a `ScrollView`.
   - Status: ✅ Requirement Fulfilled.

🛠️ Tech Stack

- Framework: .NET 9.0 MAUI
- Language: C#
- Pattern: MVVM (Model-View-ViewModel)
- UI: XAML (hand-coded grids and layouts)

🚀 How to Run

Clone or open the project folder:
```bash
git clone https://github.com/BroBYW/-Van-Gogh-Gallery-App-.NET-MAUI-.git
```

```bash
cd "d:/Mobile Development/Progress_Test/Progress_Test"
```

Using Visual Studio 2022:
- Open the folder or `Progress_Test.csproj`, restore dependencies, select a target (Android Emulator or Windows Machine), and press `F5`.

Using .NET CLI:

```bash
# Restore and build
dotnet restore
dotnet build

# Run on Windows
dotnet run -f net9.0-windows10.0.19041.0

# Run on Android (emulator or connected device)
dotnet build -t:Run -f net9.0-android
```

📂 Project Structure

- `MainPage.xaml`: Contains the entire UI layout (Floating Profile, header, masonry grid).
- `MainPage.xaml.cs`: Handles the "Read More" toggle via tap (`MainPage.xaml.cs:12`).
- `ViewModels/ProfileViewModel.cs`: Data binding, artwork collections, and "Read More" logic (`ViewModels/ProfileViewModel.cs:10`, `ViewModels/ProfileViewModel.cs:11`, `ViewModels/ProfileViewModel.cs:17`).
- `Models/Artwork.cs`: Artwork model (`Models/Artwork.cs:1`).
- `Resources/Images`: High-quality assets (portrait and landscape paintings).
- `Progress_Test.csproj`: Target frameworks and MAUI assets (`Progress_Test.csproj:4`, `Progress_Test.csproj:51`).

Developed for .NET MAUI Progress Test
