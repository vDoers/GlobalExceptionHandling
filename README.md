# GlobalExceptionHandling
Handing all unhandled exception globally.

**Purpose:** Our purpose here to grab an exception's stack trace data that help us to identify what exactly causes the issue whether in `Release Mode` or `Debug Mode`. We will be able to understand the issue and the reason that causes it. We will store this data in a `text` file that will be store in device storage.

----------


**Problem:** When we face these kinda issues during app testing, we just want a clue about where and what causes issue. We try to find a clue and assume it can be this, can be that but unfortunately nothing useful found.

----------

**Solution:**

1. As we are in `High Tech` industries we have lots of insight tool that help you to collect app insight while something went wrong. I agree they available but they have some boundaries e.g. most of them are paid actually highly paid. :)

2. Alternatively you can make your own insight grabber that will give you you app insight and clue if something went wrong while testing the app. Its will be your, you can tweak like you want. let's dive to `try{}` and `catch{}` globally.

>We will cover:

 - iOS
 - Android
