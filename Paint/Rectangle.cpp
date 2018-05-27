#include"stdafx.h"
#include"Rectangle.h"

IMPLEMENT_SERIAL(RectangleS, CObject, 1)

	RectangleS::RectangleS(CPoint start,CPoint end)
	: Shape(start,end)
{}

RectangleS::RectangleS (int x1,int y1,int x2,int y2)
	: Shape(x1,y1,x2,y2)
{}

RectangleS::~RectangleS()
{}

void RectangleS::draw(CDC *dc)
{
	dc->Rectangle(start.x,start.y,end.x,end.y);
}

bool RectangleS::pointIsIn(CPoint point)
{
	CRect temp;
	if (end.x > start.x && end.y > start.y)  temp.SetRect(start,end);
	else if (end.x < start.x && end.y < start.y)  temp.SetRect(end,start);
	else if (start.x < end.x && start.y > end.y) temp.SetRect(start.x,end.y,end.x,start.y);
	else if (start.x > end.x && start.y < end.y) temp.SetRect(end.x,start.y,start.x,end.y);
	
	return temp.PtInRect(point);
}