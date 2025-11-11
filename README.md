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

## 🧩 Current Progress 

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

```
Assets/
 └── _Project/
      ├── Scenes/
      │    ├── MainMenu.unity
      │    ├── Stage1.unity
      │    └── Summary.unity
      ├── Scripts/
      │    └── UI/
      │         ├── SceneLoader.cs
      │         └── SettingsController.cs
      ├── Prefabs/
      ├── Materials/
      └── Audio/
```

---

## 🧭 Scene Flow

```
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
```

---

## 👨‍💻 Developer

**Abdelrahman Mohamed**  
AI & Dialogue System Developer – *The Loop Project*  


GitHub: [Abdoessam0](https://github.com/Abdoessam0)  
Project Repository: [https://github.com/Abdoessam0/The-Loop](https://github.com/Abdoessam0/The-Loop)
