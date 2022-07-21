### Sequence Generator:
The sequence generator is an automated tool to generate all combinations of peptide sequences within a certain template. It accepts a template sequence and outputs the peptide sequences with the information on how many peptides are generated.

![](SequenceGenerator.png)

#### User Input:
- **Template:** The template syntax is provided as a string of characters or a group of characters. For example, a template with the syntax of R[FH]RK[-FH][{YF}{LV}D][X] will generate all peptide sequences with (1) R as the first position, (2) F or H as the second position, (3) RK as the third and fourth positions, (4) any amino acid residue except F or H as the fifth position, (5) following with YF or LV or D (which will result in different lengths of peptides), and (6) any of the standard amino acid residues at the last position. PeSA has a default list of proteinogenic amino acids defined, and this list is used when the template refers to the full standard amino acid list.
- **Generate**: This command will run the sequence generator.

#### PeSA Output:
The peptide sequences and how many are created are listed in the output window.