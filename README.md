# 🎮 The Loop – AI-Driven Life Cycle Game

**The Loop** is a Unity-based interactive narrative game that explores the human life cycle through four stages — **Childhood**, **Youth**, **Adulthood**, and **Old Age**.  
Player choices dynamically shape the story, environment, and final outcome using a lightweight AI-driven dialogue and decision system.

---

## 🚀 Project Overview

**Goal:**  
To design an AI-supported, choice-based life simulation game where player decisions influence the emotional tone and storyline of each stage.

**Core Technologies**
- Unity 2022.3 LTS (C#)
- TextMeshPro UI System
- ScriptableObjects / JSON for dialogues
- Hugging Face Inference API (planned integration for AI dialogue generation)

---

## 🧩 Current Progress (Abdelrahman Mohamed)

✅ Completed:
- Project setup and GitHub repository  
- **Main Menu Scene** (Start / Exit)  
- Scene loading logic via `SceneManager`  
- Working quit behavior for both Editor and Build  
- Clean UI layout with title and black background  
- Initial research on connecting Unity to **Hugging Face API** for AI dialogue  

🧭 Next Steps:
- Build **Settings Menu** (volume + graphics quality with saved preferences)  
- Create **Stage1** (Childhood) prototype scene  
- Develop dialogue system and integrate basic decision tree  
- Connect AI dialogue generation through Hugging Face API  

---

## 🧠 AI Integration Research

Explored methods for connecting Unity to external AI models via **REST API**, including:
- Authenticating and sending text prompts to Hugging Face models
- Handling JSON responses with `UnityWebRequest`
- Generating adaptive dialogue options in real time  
This will later allow the game’s NPCs to react intelligently to player decisions.

---

## 📁 Folder Structure

Assets/
└── _Project/
├── Scenes/
│ ├── MainMenu.unity
│ ├── Stage1.unity
│ └── Summary.unity
├── Scripts/
│ └── UI/
│ ├── SceneLoader.cs
│ └── SettingsController.cs
├── Prefabs/
├── Materials/
└── Audio/

yaml
Copy code

---

## 🧠 Scene Flow

[Main Menu]
↓
[Stage1 - Childhood]
↓
[Stage2 - Youth]
↓
[Stage3 - Adulthood]
↓
[Stage4 - Old Age]
↓
[Summary Screen]

yaml
Copy code

---

## 🧑‍💻 Developer

**Abdelrahman Mohamed**  
AI & Dialogue System Developer – *The Loop Project*  
Atatürk University  
GitHub: [Abdoessam0](https://github.com/Abdoessam0)

---

## 🔗 Repository

[https://github.com/Abdoessam0/The-Loop](https://github.com/Abdoessam0/The-Loop)
Would you like me to also write a short Turkish summary at the bottom of the README (for your Turkish teammates or supervisor)?





You said:
again 



ChatGPT said:
Of course, abdo — here’s a clean, professional, improved README.md version rewritten from scratch.
Copy it directly into your GitHub repo’s README.md file.

markdown
Copy code
# 🎮 The Loop – AI Driven Life Cycle Game

**The Loop** is a Unity-based interactive life simulation game that lets players experience four main stages of life — **Childhood**, **Youth**, **Adulthood**, and **Old Age**.  
Each decision the player makes changes the flow of the story, the environment, and the final ending.  

Developed with Unity (C#) and planned to integrate Artificial Intelligence via the **Hugging Face API** for dynamic dialogue generation.

---

## 🧠 Project Overview

**Main Objective:**  
To build an AI-assisted interactive storytelling game where player choices dynamically affect dialogue, emotion, and gameplay experience.

**Core Technologies:**
- Unity 2022.3 LTS (C#)
- TextMeshPro UI System
- ScriptableObjects / JSON for dialogue storage
- Hugging Face Inference API (for AI-driven text)

---

## 🧩 Current Progress (by Abdelrahman Mohamed)

✅ **Completed**
- Created the Unity project and GitHub repository  
- Designed and implemented the **Main Menu** with working Start and Exit buttons  
- Scene transitions (Main Menu → Stage1) using `SceneManager`  
- Quit functionality works both in Editor and Build  
- Basic UI layout (title text, centered buttons, black background)  
- Pushed all work to GitHub repository  
- Conducted research on integrating **AI dialogue system** using the Hugging Face API  

🧭 **Next Steps**
- Develop the **Settings Menu** (volume and graphics options with PlayerPrefs saving)  
- Create **Stage1 (Childhood)** gameplay prototype  
- Implement dialogue + decision tree logic  
- Connect the game to Hugging Face for real-time AI dialogue generation  

---

## 🧠 AI Integration Research

Explored how to:
- Send player inputs from Unity to Hugging Face’s API via `UnityWebRequest`  
- Receive generated text responses from AI models  
- Use the results to create branching dialogue and emotional interactions  

This research will form the basis for the AI dialogue system in later phases of *The Loop*.

---

## 🗂️ Folder Structure

Assets/
└── _Project/
├── Scenes/
│ ├── MainMenu.unity
│ ├── Stage1.unity
│ └── Summary.unity
├── Scripts/
│ └── UI/
│ ├── SceneLoader.cs
│ └── SettingsController.cs
├── Prefabs/
├── Materials/
└── Audio/

yaml
Copy code

---

## 🧭 Scene Flow

[Main Menu]
↓
[Stage1 – Childhood]
↓
[Stage2 – Youth]
↓
[Stage3 – Adulthood]
↓
[Stage4 – Old Age]
↓
[Summary Screen]

yaml
Copy code

---

## 👨‍💻 Developer

**Abdelrahman Mohamed**  
AI & Dialogue System Developer – *The Loop Project*  
Atatürk University  

GitHub: [Abdoessam0](https://github.com/Abdoessam0)  
