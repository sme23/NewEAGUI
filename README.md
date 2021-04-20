# NewEAGUI
A new GUI for Event Assembler using ColorzCore.

## How to Use
Place in the same directory as ColorzCore and run. Options available:

- `Show build times`: Outputs detailed timing information for all processes run during operation
- `Output no$ .sym file`: Outputs a `.sym` file intended for use with the emulator `NO$GBA` containing offsets of all labels defined when building
- `Suppress messages`: Does not output messages
- `Suprress warnings`: Does not output warnings
- `No colored log`: Does not color output messages according to type message/warning/error. Has no effect within the displayed output message
- `Treat warnings as errors`: Throws errors instead of warnings, preventing a successful build if any warnings are present
- Selections for language from `FE6`, `FE7`, and `FE8` with `FE8` selected by default; also allows for a custom language setting
- Ability to output changes to the given ROM or to output an assembly source file and linker script

