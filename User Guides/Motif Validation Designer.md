### Motif Validation Designer:
![](MotifValidation.png)


#### User Input:
- **Load Motif**: A PeSA generated motif needs to be load by using the Load Motif button on the bottom left.
- **Wildtype (Display only)**: If the motif file contains a wildtype sequence, it will be displayed. It is used only if the motif target position is set.
- **Specificity Cut-off**: For each position in the positive motif, if the number of amino acid residues is less than or equal to the positive specificity cut-off value entered, those amino acid residues will be used as options for that position. Otherwise, the amino acid of the wildtype sequence at that position will be used. Similarly, if the number of amino acid residues is less than or equal to the negative specificity cut-off value entered for a position in the negative motif, those amino acid residues will be added to the options list for that position. 

#### PeSA Output:
- **Template:** A template with the same syntax as the [[Sequence Generator]] is generated to create the possible combinations of peptide sequences. 
- **Validation List**: The results of the Motif Validation Designer are listed in a list format with the template used to generate. The template generated as explained above is displayed, with all the combinations generated using that template. The generated peptide list is presented in two groups: (1) Positive motif only, which contains peptides that use the amino acids only from the positive motif, and (2) Including negative motif, which includes amino acids from the negative motif as well.

#### Further Features:
- **Export to Excel**: PeSA can export all the input and output data of the analysis as an Excel file, presenting both the raw and processed data to the user. The exporting capability allows full access to the data in case further analysis not covered by PeSA needs to be done on the dataset.