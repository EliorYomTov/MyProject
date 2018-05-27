#include "stdafx.h"
#include "Line.h"
#include <math.h>

IMPLEMENT_SERIAL(LineS, CObject, 1)

LineS::LineS(CPoint start,CPoint end)
	: Shape(start,end)
{}

LineS::LineS (int x1,int y1,int x2,int y2)
	: Shape(x1,y1,x2,y2)
{}

LineS::~LineS()
{}

void LineS::draw(CDC *dc)
{
	dc->MoveTo(start);
	dc->LineTo(end);
	dc->MoveTo(start);
}

bool LineS::pointIsIn(CPoint point)
{
	float d1 = (end.y-start.y)*point.x-(end.x-start.x)*point.y+(end.x*start.y)-(end.y*start.x);
	float d2 = (end.y-start.y)*(end.y-start.y) + (end.x-start.x)*(end.x-start.x);
	float dist = abs( d1 ) / sqrt( d2 ) ;
	if( ( dist <= 0 && dist >= -10) || (dist >= 0 && dist <= 10) )
		return true;
	
	return false;
}