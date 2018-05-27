#include"stdafx.h"
#include "Shape.h"


Shape::Shape (CPoint start,CPoint end)
{
	this->start = start;
	this->end = end;
	borderSize = borderColor = fillColor = 0;
}

Shape::Shape(int x1,int y1,int x2,int y2)
{
	this->start.x = x1;
	this->start.y = y1;
	this->end.x = x2;
	this->end.y = y2;
	borderSize = borderColor = fillColor = 0;
}

Shape::Shape (const Shape &other)
{
	(*this) = other;
}

Shape::~Shape()
{}

void Shape::Serialize (CArchive& ar)
{
	CObject::Serialize (ar);
	if (ar.IsStoring ())
	{
		ar << start.x << start.y << end.x << end.y << borderColor << fillColor << borderSize;
	}
	else 
	{
		ar >> start.x >> start.y >> end.x >> end.y >> borderColor >> fillColor >> borderSize;
	}
}

const Shape & Shape::operator=(const Shape &other)
{
	this->start = other.start;
	this->end = other.end;
	this->borderColor = other.borderColor;
	this->fillColor = other.fillColor;
	this->borderSize = other.borderSize;
	return (*this);
}

void Shape::setStart(const CPoint start)
{
	this->start = start;
}

void Shape::setEnd(const CPoint end)
{
	this->end = end;
}

