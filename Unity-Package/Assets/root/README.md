# Non Drawing Graphic

![npm](https://img.shields.io/npm/v/extensions.unity.nondrawinggraphic) [![openupm](https://img.shields.io/npm/v/extensions.unity.nondrawinggraphic?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/extensions.unity.nondrawinggraphic/) ![License](https://img.shields.io/github/license/IvanMurzak/Unity-NonDrawingGraphic) [![Stand With Ukraine](https://raw.githubusercontent.com/vshymanskyy/StandWithUkraine/main/badges/StandWithUkraine.svg)](https://stand-with-ukraine.pp.ua)

Unity UI component which doesn't have drawing event at all. But still can receive click events. More optimized to have something invisible and clickable in Unity UI.

# Usage

Add `NonDrawingGraphic` component to UI Game Object under Canvas in Unity Scene.

![image](https://user-images.githubusercontent.com/9135028/222345963-57812733-26f1-47b0-9c02-b87ce7a3e037.png)

# Installation

### Option 1 - Installer

- **[⬇️ Download Installer](https://github.com/IvanMurzak/Unity-NonDrawingGraphic/releases/latest/download/Non-Drawing-Graphic-Installer.unitypackage)**
- **📂 Import installer into Unity project**
  > - You may use double click on the file - Unity will open it
  > - OR: You may open Unity Editor first, then click on `Assets/Import Package/Custom Package`, then choose the file

### Option 2 - OpenUPM-CLI

- [⬇️ Install OpenUPM-CLI](https://github.com/openupm/openupm-cli#installation)
- 📟 Open command line in Unity project folder

```bash
openupm add extensions.unity.nondrawinggraphic
```

### Option 3 - Manual (manifest.json)

- Add this code to `/Packages/manifest.json`

```json
{
  "dependencies": {
    "extensions.unity.nondrawinggraphic": "1.0.1"
  },
  "scopedRegistries": [
    {
      "name": "package.openupm.com",
      "url": "https://package.openupm.com",
      "scopes": [
        "extensions.unity"
      ]
    }
  ]
}
```
