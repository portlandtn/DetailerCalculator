# DetailerCalculator

The intention of this program is to provide the detailing department a means of doing architecural math easily.

Basic functions include:

Understanding of converting a decimal foot or decimal inch number into a format matching feet-inch-16's using #ft.in16 format.
Basic trig functions inluding Base to slope, slope to base, base to rise, and others.
Using two sides of a triangle to determine all angles.

Use number keyboard input to expedite data entry.

## Shared numeric compatibility fixtures

`fixtures/numeric-compatibility.v1.json` is a platform-neutral versioned fixture set, copied byte-for-byte into DetailerCalculatorWebapp. Inputs/expected outputs include an independent arithmetic identity or geometric basis and explicit absolute tolerances. Covered: negative dimensions, sixteenths, carry at one foot, 3-4-5 triangles, 30/45-degree trig, and RPN subtraction/division order. Fixture changes must update both repositories in coordinated PRs; compare file digests before accepting.

Run `dotnet run --project tests-portable/Compatibility.csproj` with .NET 10. The harness compiles the original numeric source files; the only desktop source edit removes an unused WinForms import. No desktop arithmetic behavior is replaced. The web repository runs the identical data through its real TypeScript functions with `npm test`. This is numeric coverage, not a Windows Forms build or UI release test. Singular trig, negative carry symmetry, extreme magnitudes and every rounding mode still need additional agreed cases before claiming full desktop/web parity.
