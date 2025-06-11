from gtts import gTTS

text = """
Hi everyone, and welcome to our course on SOLID principles — a cornerstone of writing clean, 
maintainable, and scalable object-oriented code.
Whether you're a junior developer building your foundation or a seasoned coder looking to 
refine your architecture skills, you're in the right place.
Over the next sessions, we'll dive into what makes code not just work, 
but last. 
You'll learn to spot design flaws early, refactor with confidence,
and write software that's easier to understand, test, and extend.
"""

tts = gTTS(text, lang='en', tld='com')  # American English accent
tts.save("solid_course_welcome.mp3")
print("Saved as solid_course_welcome.mp3")
