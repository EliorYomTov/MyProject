#include "stdafx.h"
#include "Ellipse.h"
#include <math.h>
IMPLEMENT_SERIAL(EllipseS, CObject, 1)

	EllipseS::EllipseS(CPoint start,CPoint end)
	: Shape(start,end)
{}

EllipseS::EllipseS (int x1,int y1,int x2,int y2)
	: Shape(x1,y1,x2,y2)
{}

EllipseS::~EllipseS()
{}

void EllipseS::draw(CDC *dc)
{
	dc->Ellipse(start.x,start.y,end.x,end.y);
}

bool EllipseS::pointIsIn (CPoint point)
{
	double xRadius = (end.x - start.x) / 2;
	double yRadius = (start.y - end.y) / 2;
	double xCentre = start.x + xRadius;
	double yCentre = end.y + yRadius;
	double result;
	result = (pow((point.x - xCentre),2)/pow(xRadius,2)) + (pow((point.y - yCentre),2)/pow(yRadius,2));
	return  (result <= 1.0);
}
