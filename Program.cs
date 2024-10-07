//*****************************************************************************
//** 2696. Minimum String Length After Removing Substrings   leetcode        **
//*****************************************************************************


int minLength(char * s){
    int count = strlen(s); // Initial length of the string
    int i = 0;

    while(i < count - 1) // Loop until the second last character
    {
        int convert = s[i];
        int convert2 = s[i+1];

        if(((convert == 'A') && (convert2 == 'B')) || ((convert == 'C') && (convert2 == 'D')))
        {
            // Remove the two adjacent characters by shifting the rest of the string
            memmove(&s[i], &s[i+2], count - i - 1); // Move the rest of the string left by 2 positions
            count -= 2; // Decrease the count since two characters are removed
            if(i > 0) i--; // Move i back one step to recheck the previous character
        }
        else
        {
            i++; // Move to the next character
        }
    }

    return count;
}