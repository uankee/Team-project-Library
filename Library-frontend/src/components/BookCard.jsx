import React from 'react';
import { Card } from 'antd';
import { Link } from 'react-router-dom';

import NoImage from '../img/NoImage.png';

function BookCard({ Book }) {
  const { id, title, coverImage, authorName, genreName, publishedDate } = Book;
  const formattedDate = publishedDate ? publishedDate.slice(0, 4) : '';

  return (
    <Card hoverable className="card" bodyStyle={{ padding: 12 }}>
      <Link to={`book/${id}`}>
        <img
          className="book-image"
          draggable={false}
          alt={title}
          src={coverImage == null ? NoImage : coverImage}
        />
      </Link>
      <div className="book-card-meta">
        <h3 className="book-card-title">{title}</h3>
        <p className="book-card-subtitle">
          {[authorName, genreName, formattedDate].filter(Boolean).join(' • ')}
        </p>
      </div>
    </Card>
  );
}

export default BookCard;
