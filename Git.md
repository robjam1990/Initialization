# Control

Certainly! Here’s an updated and more organized version of the keyboard shortcuts and REPL commands:

---

## Keyboard Shortcuts

- **Enter**: Evaluate the current submission if it appears to be complete. Otherwise, insert a new line.
- **Ctrl-Enter**:
  - Evaluate the current submission.
  - Append a previous submission to the current submission when executed within a previous submission.
- **Shift-Enter**: Insert a new line.
- **Escape**: Clear the current submission.
- **Alt-UpArrow**: Replace the current submission with a previous submission.
- **Alt-DownArrow**: Replace the current submission with a subsequent submission (after having previously navigated backwards).
- **Ctrl-Alt-UpArrow**: Replace the current submission with a previous submission beginning with the same text.
- **Ctrl-Alt-DownArrow**: Replace the current submission with a subsequent submission beginning with the same text (after having previously navigated backwards).
- **Ctrl-K, Ctrl-Enter**: Paste the selection at the end of the interactive buffer, leaving the caret at the end of the input.
- **Ctrl-E, Ctrl-Enter**: Paste and execute the selection before any pending input in the interactive buffer.
- **Ctrl-A**:
  - First press: Select the submission containing the cursor.
  - Second press: Select all text in the window.
- **UpArrow**:
  - At the end of the current submission: Replace the current submission with a previous submission.
  - Elsewhere: Move the cursor up one line.
- **DownArrow**:
  - At the end of the current submission: Replace the current submission with a subsequent submission (after having previously navigated backwards).
  - Elsewhere: Move the cursor down one line.

---

### REPL Commands

- **$$**: A comment marker.
- **$cls, $clear**: Clears the contents of the editor window, leaving history and execution context intact.
- **$help**: Display help on a specified command, or all available commands and key bindings if none specified.
- **$load [filename]**: Executes code and commands from the specified file without resetting the current state.
- **$mod [module]**: Switches the current scope to the specified module name.
- **$reset**: Resets the execution environment to the initial state, keeping the history.
- **$wait [milliseconds]**: Waits for at least the specified number of milliseconds.

---

Feel free to provide more context or specific requirements if you need further adjustments!