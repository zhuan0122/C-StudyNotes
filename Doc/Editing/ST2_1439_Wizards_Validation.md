## Validation Requirements for Wizard 
### From ST2-1439

To reduce the risk of introducing errors due to badly formatted property values validation should be performed on any (free text) user input. As a rule the validation be performed as early as possible in the work flow and the feedback to the user sohuld be as immediate and clear as possible.

The following validation checks should be supported:

##### validated text (regexp)
any sequence of characters satisfying the validation criteria
the validation criteria is typically a regexp.
##### identifier
any string that satisfy the regexp of an ANSI-C variable name (.dbc and SW compatibility), i..e /^[A-Z_][A-Z0-9_]*$/i
##### name
any string that satisfy the identifier regexp and space
##### integer (decimal)
any decimal number satisfying the regexp /^0|(-?[1-9][0-9]*)$/
potentially with a constraint, e.g. > x, < x, >= x, <= x, or range [lower, upper]
##### integer (hexadecimal) or hex
any hexadecimal number satisfying the regexp /^-?0x[0-9A-F]+$/i
potentially with a constraint, e.g. > x, < x, >= x, <= x, or range [lower, upper]
##### real
any real number satisfying the regexp /^(0|-?(0|[1-9][0-9])([.,][0-9]+)?)$/
potentially with a constraint, e.g. > x, < x, >= x, <= x, or range [lower, upper]
##### boolean
either True or False
##### PGN
any integer, decimal or hexadecimal, that satisfies the constraints of J1939 (see Part 21 chapter 5) concerning PGNs.
Note that the check should identify illegal PGNs, for instance a PDU1 PGN with a defined destination address, e.g. 0xEF11 (should be 0xEF00).
##### date <format>
date according to the <format>, e.g. YY:MM:DD
default format is YY:MM:DD
##### time <format>
time according to the <format>, e.g. hh:mm:ss
default format is hh:mm:ss
##### date time <format>
the date according to the <format>, e.g. YY:MM:DD hh:mm:ss
default format is YY:MM:DD hh:mm
##### SOP
any string that satisfies the regexp /^SOP(-| +)?[0-9] {4}$/i
##### CR
any string that satisfies a valid CR regexp, e.g. /^SSCR-[1-9][0-9]*$/i
##### FPC code
any string that satisfies the regexp /^FPC[0-9]+[A-Z] {0,2}$/
##### FPC condition
any string that satisfies the following language
* condition := expr
* expr := code | and | or | group
* and := expr “AND” expr
* or := expr “OR” expr
* group := “(“ expr “)”
* code := see above
##### enumeration
any value defined for the enumeration
##### unformatted text
any sequence of characters, including newline.
##### formatted text (format)
any sequence of characters, including newline.
interpreted using the supplied format, e.g. rich text, html, etc.
default is rich text.
##### link
a clickable url
named link
a clickable name representing an url
##### type list
a sequence of values satisfying type, e.g. named link list, a list of named links
If a validator above is preceded with the unique qualifier, then it should be understood that the value should be unique among all objects of that type. The scope could be relaxed as well, e.g. a parent unique name would mean that the value must be a name and unique among all objects of the same type with the same parent.
