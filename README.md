# ChordKeys
ChordKeys is a software application for Windows which runs in the background. It intercepts simultaneous keystrokes (i.e., keystrokes within 30ms of each other) and replaces them with foreign characters when appropriate. In its current state I believe it should be sufficient for German, French, Spanish, Italian, Portuguese, Norwegian, Danish, Swedish, romanized Punjabi, and romanized Arabic.

## Why ChordKeys? What can I use instead?
I made ChordKeys because I found the existing options frustratingly slow and un-ergonomic. Your alternatives include:
* AutoHotKey - There are scripts that allow this, but they either require holding down a system key (like SHIFT or CTRL), or have weird caveats and unpredictable behavior.
* HoldKey - The free version makes you use the mouse to click the accent you want. The paid version costs money. And then you have to hold the key long enough to get the prompt. If you're not a touch-typer though this is probably just fine.
* Microsoft Window's foreign keyboard layout settings - This is a reasonable solution if you are using a non-latin script (for example, hindi or japanese), but can get really annoying if you are switching between two latin based keyboards. Remembering what mode you are in can be difficult, and if you forget you can type for a long time before you hit a key that's in a different place. Plus some languages (cough cough **French**) have terrible native keyboards that don't even let you get to all the characters you need. Though if you like vim maybe this is the solution for you.
* Microsoft Keyboard Layout Creator (MKLC) - You can make your own keyboard layout and install it with this tool from Microsoft. However you will have to either remap some of your keys, or use right-alt as an ALTGR key. Remapping keys is annoying if you also program and can find literally every key on the keyboard without looking at it. Right ALT is uncomfortable to hit and was giving me RSI in my right hand. Perhaps you'll have better luck.
* WinCompose - compose key for windows. Every combo takes three keys, because you have to start with the compose key. This is slow, and if you make your compose key right ALT like I did your right hand may start to hurt when you're typing a lot of special characters. Still an excellent piece of software.

## Installation
Download the latest ChordKeysSetup.msi file from the releases page and run it. This software is not properly signed so you will have to give permissions for software from "unknown publisher" to run (If you know how to fix this feel free to submit a pull request or something). When you are done with setup, ChordKeys will be run automatically, and is set-up to run after you log into your account.

## Help I want to uninstall
Use Window's Add or Remove programs tool. When you uninstall ChordKeys through that tool, it should kill the currently running ChordKeys process and completely remove ChordKeys from your system.

## How to use
Once ChordKeys is installed, certain combinations of characters will produce special characters. The following characters are currently supported, in both lowercase and uppercase:  
* ae -> æ
* oe -> œ
* sz -> ß
* ,c -> ç
* ,s -> ş
* /o -> ø
* 0a -> å
* ng -> ŋ
* ' (or ") + any vowel or y -> acute accent (á, é, í, ó, ú, ý)
* ^ (or 6) + any vowel or y or w -> circumflex accent (â, ê, î, ô, û, ŵ, ŷ)
* ; (or :) + any vowel or y -> diaresis accent (ä, ë, ï, ö, ü, ÿ)
* ` (or ~) + any vowel or y -> grave accent (à, è, ì, ò, ù, ỳ)
* \- (or _) + any vowel but not y -> macron accent (ā, ē, ī, ō, ū)
* 5 (or %) + any vowel or y or n -> tilde accent (ã, ẽ, ĩ, õ, ũ, ñ, ỹ)
* h (or H) + any stop consonant -> aspirated stop (bʰ, cʰ, dʰ, gʰ, jʰ, kʰ, pʰ, rʰ, tʰ)
* . (or >) + (h, s, d, t or z) -> underdotted character (ḥ, ṣ, ḍ, ṭ, ẓ)
Other chords:
* 4e -> €
* 4l -> ₤
* ,' -> ‹
* .' -> ›
* <" -> «
* \>" -> »
* 12 -> ¡
* /2 -> ¿
* ;, -> ‚ (german left single-quote mark)
* :< -> „ (german left double-quote mark)

## The character I'm looking for isn't supported
I've done my best to cover common use-cases, but if something you need is missing feel free to let me know and I'll look into it.
* Edit DefaultChordKeyScript.ck and submit a pull request.
* Add a bug.
* Contact me some other way.
Then I'll get to it when I get to it. Remember this software is free.

## I'm finding the combos to easy to hit by accident or too difficult to hit on purpose
I found 30ms works for me. You may need to build some muscle memory and it may take some getting used to. If there is demand for a user-setting that can change the time interval, I will add it, so feel free to open a bug (or comment on an existing one for this purpose if someone's already made a bug).

## Caveats
This probably won't play nice with any other application that intercepts keystrokes. You can have them both installed, but I can't tell you what will happen if you do something that triggers both applications at the same time.  

The background process may get killed for no apparent reason. This has only happened to me once so far after weeks of use. Let me know if it happens to you and I'll look harder into fixing it. In the meantime you can either restart or find and run ChordKeys.exe in the ProgramFiles/ChordKeys directory.

The chord mappings were based on a standard US-QWERTY keyboard, and may not be ergonomic or make much sense on other layouts. If there is demand for it I will allow for alternate settings that may make more sense on other keyboards.

## I want this but I'm running Mac or Linux
Sorry, I currently only made this for Windows. I will probably make a variant for Linux in the future but don't hold your breath. If you want a version for Mac I invite you to add one yourself and submit a pull request.
