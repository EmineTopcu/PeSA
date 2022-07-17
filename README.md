# PeSA

**Pe**ptide **S**pecificity **A**nalysis

PeSA is an open source software designed as a tool to use in the analysis of peptide arrays, permutation arrays and OPALs.

Analysis can be used to generate motifs to share the results as a position-specific scoring matrix (PSSM).

## Installation

PeSA consists of a single executable that can be downloaded from the Releases section on the right. The windows executable file can be downloaded from [Releases](https://github.com/EmineTopcu/PeSA/releases/tag/v2.0) section on the right side of this window. Depending on the operating system the software will run on, PeSA.Windows.32-bit.exe or PeSA.Windows.32-bit.exe needs to be downloaded. As the software is not officially certified, some systems may give security warnings, which need to be ignored or overridden for a successful download.

## Running an Analysis

PeSA offers multiple analysis types, including motif generation, validation and prediction, which are explained below.

### Peptide List:
In this module, PeSA generates a sequence motif using the frequency of each amino acid residue at each position in the given peptide list. In the case of a key position and target amino acid supplied, an alternative 'shifted' motif is generated for the peptides in the list but does not match the target key and position rule.

![[PeptideList.png]]

- **Peptide List:** The list of peptides can be loaded by using the **Load from File**, or it can be directly copied to the list from the clipboard. As in all PeSA modules, the peptides read are handled in a case-sensitive manner.
- **Peptide Length:** By default, the length of the first peptide in the peptide list is considered the motif length. This value can be overridden by the user if there are extra characters at the end of the peptides that need to be excluded from the analysis. If any peptide has a length larger than this set peptide length, the extra characters at the end will be ignored.
- **Key Position:** This field is meaningful only if the Target Amino Acid parameter is also set. If these two values are defined, peptides in the list are split into two: The ones with the target amino acid at the key position and those without. As a result, two motifs are created as regular and shifted motifs, as described in 2.2.3. If any of the Key Position and Target Amino Acid fields are left blank, only one motif is generated to represent the whole peptide list.
- **Frequency Threshold:** An amino acid residue must be observed at a certain frequency or above at a specific position to be represented in the motif. The frequency threshold represents this threshold.
- **Output:** If a shifted motif is generated as described above, the details on which direction a peptide is shifted are listed in the output window.
- **Save/Load Project**: The analysis data and the configuration values can be saved in a JSON format for easy access.
- **Export to Excel**: PeSA can export all the input and output data of the analysis as an Excel file, presenting both the raw and processed data to the user. The exporting capability allows full access to the data in case further analysis not covered by PeSA needs to be done on the dataset.
- **Run Scorer**: Provides a direct link to the **Motif Based Peptide Scorer** and **Motif Based Protein** modules explained below.
- **Save Motif**: The motifs are saved in a format that PeSA's other modules can open.

### Peptide Array:
Peptide array analysis is similar to peptide list analysis in that it creates a frequency-based motif. However, the provided input is not only made up of peptides that go through positive interaction but the full data set of a study.

![[PeptideArray.png]]

- **Peptides:** The peptide array can be fed to PeSA as a list of peptides or in an array format, using the **Load from File** link. If a list is used as the input, a matrix is generated using the default number of rows and columns set in the settings menu. The user also sets whether the matrix will be generated as rows first or columns first in the settings menu.
- **Quantification (Background Normalized):** The background normalized quantification values must be loaded to PeSA for analysis. Direct copying from the clipboard is possible, as well as importing from an Excel file using the **Load from File** link.
- **Normalized:** The background normalized quantification values of the peptide array are further normalized to have a similar scale across multiple studies. The background quantification values are divided by the **Normalize By** value. The Normalize By value is set to the maximum value in the quantification matrix by default but can be overridden by the user.
- **Threshold:** The normalized values greater than or equal to the threshold value are accepted to have gone through the positive interaction studied in the array. The list of peptides that have values greater than the threshold is used to generate the frequency-based motif. A shifted motif is also created using the same list of peptides using the criteria explained above with target position and key amino acid.
- **Negative Threshold:** The normalized values smaller than the negative threshold value are considered to belong to peptide sequences that have not gone through positive interaction. Any peptide sequence having a valuer between the threshold and the negative threshold is considered inconclusive.
- **Motif:** The motif tab displays the frequency-based motif generated and the shifted motif in case of target position, and key amino acid values are defined.
- **Info:** The information entered here is not used by PeSA for analysis. It is a place for the researcher to keep the original image together with the analysis.
- **Decision List:**  The decision of which peptides have or have not gone through positive interaction based on the threshold, and negative threshold values are listed in a list format.
- **Save/Load Project**: The analysis data and the configuration values can be saved in a JSON format for easy access. PeSA uses .ppep extension for peptide array analysis projects.
- **Export to Excel**: PeSA can export all the input and output data of the analysis as an Excel file, presenting both the raw and processed data to the user. The exporting capability allows full access to the data in case further analysis not covered by PeSA needs to be done on the dataset.
- **Run Scorer**: Provides a direct link to the **Motif Based Peptide Scorer** and **Motif Based Protein** modules explained below.
- **Save Motif**: The motifs are saved in a format that PeSA's other modules can open.

### Permutation Array:
PeSA can generate weight-based positive and negative motifs using numeric values of a permutation array.

![[PermutationArray.png]]

- **Quantification:** Background normalized quantification values need to be fed to PeSA for analysis. The wildtype sequence, as well as the order of the permutation sequence, should be included in the input array as row and column headers.
- **X-Axis Wildtype:** PeSA automatically determines whether the column or row header represents the wild type or the permutation sequence with the simple logic that the permutation sequence should not have any repeating amino acids. In the case of the wildtype sequence consisting of non-repeating characters and the decision is not straightforward, the user can define whether the X-axis (i.e., column headers) contains the wild type or not. If unchecked, the wildtype sequence is represented in the y axis of the array (i.e., row headers).
- **Y-Axis** Top to Bottom: In the case of the y-axis representing the wildtype sequence, for the correct directionality of the motif, the user can define whether the first character of the wildtype sequence is the one on the top or the bottom.
- **Normalized:** Background normalized quantification values are further normalized by dividing all values by the value of the wildtype sequence. As there can be as many wildtype sequences in the permutation array as the length of the wildtype sequence's length -1, there comes the question of which value to use for normalization. The options available to choose from are **Mean Value** and **Per Row/Column**. The decision should be based on the homogeneity of the expression across the autoradiography image of the array analyzed. If, for some reason, any rows or columns are expressed differently than the rest and the quantification values of different wildtype sequences are different across the array, using the 'Per Row/Column' option may generate more accurate results. Otherwise, 'Mean Value' is a reasonable approximate that averages the values of all of the wildtype sequence quantifications.
- **Peptides:** As only the column and row headers are provided to PeSA as the wildtype sequence and permutation sequence, PeSA automatically generates the peptide sequences represented at each array's position. This output can be useful to search for certain sequences within the array and confirm that 'X-Axis Wildtype' and 'Y-Axis Top to Bottom' settings are set properly.
- **Motifs:** Weight-based motifs are generated using the normalized values of the permutation array. Each amino acid's weight at a specific position is determined by the normalized weight of the peptide with that amino acid at that position. A **positive motif** is generated by using the peptides with normalized values larger than the threshold entered by the user. Similarly, a **negative motif** is generated using the peptides with normalized values smaller than the negative threshold value set.
- **Chart**: PeSA generates a bar chart display, incorporating positive and negative motif information within the same scale. The same numerical values used in the positive and negative motifs are used as the bar lengths. As the values are used directly rather than their ratio, as done in motifs, they can be used to compare different positions.
- **Visual Matrix**: A visual matrix is generated in gray or blue-red scale to represent the numeric values of the permutation array.
- **Info** and **Decision List** features are similar to the peptide list module explained above.
- **Save/Load Project**: The analysis data and the configuration values can be saved in a JSON format for easy access. PeSA uses the .pprm extension for permutation array analysis projects.
- **Export to Excel**: PeSA can export all the input and output data of the analysis as an Excel file, presenting both the raw and processed data to the user. The exporting capability allows full access to the data in case further analysis not covered by PeSA needs to be done on the dataset.
- **Run Scorer**: Provides a direct link to the **Motif Based Peptide Scorer** and **Motif Based Protein** modules explained below.
- **Save Motif**: The motifs are saved in a format that PeSA's other modules can open.

### OPAL Array:
OPAL array analysis is similar to permutation array analysis. Even though there is no wildtype sequence, each position in the array has only one single amino acid expressed more than others. By contributing the study results of a position to the amino acid with weight change in that position, PeSA creates positive and negative motifs using the positive and negative thresholds defined by the user.

![[OpalArray.png]]

### Sequence Generator:
The sequence generator is an automated tool to generate all combinations of peptide sequences within a certain template. It accepts a template sequence and outputs the peptide sequences with the information on how many peptides are generated.

![[SequenceGenerator.png]]

**Template:** The template syntax is provided as a string of characters or a group of characters. For example, a template with the syntax of R[FH]RK[-FH][{YF}{LV}D][X] will generate all peptide sequences with (1) R as the first position, (2) F or H as the second position, (3) RK as the third and fourth positions, (4) any amino acid residue except F or H as the fifth position, (5) following with YF or LV or D (which will result in different lengths of peptides), and (6) any of the standard amino acid residues at the last position. PeSA has a default list of proteinogenic amino acids defined, and this list is used when the template refers to the full standard amino acid list.

### Motif Based Peptide Scorer:
PeSA-generated positive and negative motifs can be used to score a peptide list in terms of similarity to the motifs.

- **Wildtype**: If the motif file contains a wildtype sequence, it will be displayed. It is used only if the motif target position is set.
- **Motif Target Position**: In a motif, there can be a central point that needs to match the peptides being scored. For example, if the researcher is studying lysine methylation, it is more meaningful to score a peptide by aligning the lysine in it to the lysine in the wildtype sequence. The motif target position is the index of that specific position in the wildtype sequence. If such a position is not provided, for every peptide in the list to be scored, all the partial sequences within the peptide with the length of the motif will be scored separately.
- **Motif Thresholds**: The positive and negative thresholds used to generate the motifs are displayed for informational purposes. These values can be used as a reference if the user wants to employ stricter thresholds.
- **Changed Thresholds**: The user can enter a positive threshold higher than the positive threshold of the motif. Similarly, a negative threshold smaller than the negative threshold of the motif can be used as well. For example, if the positive threshold is set as 0.6 in the motif, all the amino acid residues within the motif would have normalized values equal to or greater than 0.6. If a changed threshold of 0.8 is entered, the decision of a positive match would be more difficult. Only a normalized value of 0.8 would cause an amino acid to be considered a positive match. As an extreme example, entering zero as the negative changed threshold will practically ignore the negative motif in scoring.
- **Match Cut-off**: By default, PeSA scores all the peptides to the given motifs. However, when working with a long peptide list, simply focusing on the peptides with at least a certain number of positive matches or at most a certain number of negative matches may be more efficient. These values can be entered through Positive and Negative Match Cut-Off entries, respectively. Even though scoring a few thousand peptide sequences takes only a few seconds (if a motif target position is provided), limiting the subset of output by match cut-off values can help save time in further analysis.
- **Peptide List:** The peptide list to be scored can be loaded from a file or pasted directly from the clipboard. The length of the peptides in the list does not need to match the length of the motif. Instead, scoring will be done by skimming each peptide segment of the motif size from left to right.
- **Score List**: The result is displayed in a list format, as shown in Figure S1 of the Supplementary Materials. The columns include (1) Peptide, (2) Segment, and (3) all the calculated score values. Note that a peptide can have multiple scores if the length of the motif is shorter than the peptide or there are multiple positions in the peptide with a match to the 'Motif Target Position.' The region of the peptide that is scored is displayed under the 'Segment' column.

### Motif Based Protein Scorer:

### Motif Validation Designer: