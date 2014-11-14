#!perl -w

use strict;

my $filepath = "C:/Users/ASPePeX/Downloads/blender-2.72b/blender-2.72b/source/blender/makesrna/intern";
my @alltherna;

opendir(IN, $filepath);
my @dir = readdir(IN);
closedir(IN);

foreach my $file (@dir)
	{
	if ($file =~ /RNA_/gi)
		{
#		print $file . "\n";
		open(IN, "<$filepath/$file");
		my @filecontent = <IN>;
		close(IN);

		foreach my $line (@filecontent)
			{
			if ($line =~ /(RNA_def_\w*)/g)
				{
				push(@alltherna, lc $1 . ",\n");
				}
			}		
		}
	}
my @uniquerna = sort(uniq(@alltherna));

open(OUT, ">rnalist.txt");
print OUT @uniquerna;
close OUT;

sub uniq
	{
	my %seen;
	grep !$seen{$_}++, @_;
	}