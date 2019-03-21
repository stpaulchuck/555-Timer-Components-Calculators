# 555 Timer Components Calculators

![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](http://www.repostatus.org/badges/latest/inactive.svg)
[![lifecycle](https://img.shields.io/badge/lifecycle-stable-green.svg)](https://www.tidyverse.org/lifecycle/#stable)

## Description

I needed a quick calculator for my 555 timer projects. I got tired of dragging out the spec sheet and the hand calculator any time I needed to find the values for a frequency or a one-shot monostable setup so I sat down and wrote these two apps. One is for the astable (free running) variety and the other one is for the monostable (one-shot) version.

The usage is pretty straight forward. You input whichever knowns you have like the two resistors and freqency and then let the calculator compute the unknown, in this instance, the capacitor. I won't write a twelve page 'how-to' for them as you are all more than able to make the calculators work without my blathering on about it. Enjoy them. They make life a little bit easier. \*grin\*

## The Project

These are straight forward Windows Forms applications. There are tooltips for when you mouse over a place or label that is active but not immediately intuitive as a control. It's a handy way to alert your users to 'hidden' controls that are in plain sight, but not obvious. The setup code is really simple. Just go to the properties for the control or label you want a tool tip to pop up and scroll down to the Tool Tip property and enter the text. If you use the wired in Tool Tip object then you'll want to set up the various characteristics. Look at class constructor code at the top of the code page and you'll see how to do that.

The graphics are basically a rip of the ones in the Fairchild spec sheet I included in the "docs" folder. If you look on pages 4 and 5 in the spec sheet you'll see similar layouts. I modified the layout a bit to please my eye. The graphics are not active so you can change them to suit yourself.

I am uploading both the source files and the compiled applications. That way you can test drive them and see if they look like something you'd like to use and/or dive into the code. Either way, ENJOY!

## License

This software is licensed under the GNU General Public License Version 3 (and newer if published).
